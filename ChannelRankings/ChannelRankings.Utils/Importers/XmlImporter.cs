using System.IO;
using System.Linq;
using System.Xml.Serialization;
using ChannelRankins.Contracts.Data;
using ChannelRankins.Contracts.Utils;
using System.Collections.Generic;
using ChannelRankings.Models.Authorities;

namespace ChannelRankings.Utils.Importers
{
    public class XmlImporter : IXmlImporter
    {
        private const string XmlFilePath = "../../generated-channels.xml";

        public XmlImporter(IChannelModelMapper modelMapper, ISqlServerDatabase database)
        {
            this.Database = database;
            this.ModelMapper = modelMapper;
        }

        protected ISqlServerDatabase Database { get; set; }

        protected IChannelModelMapper ModelMapper { get; set; }

        public void Import()
        {
            using (var fileStream = new FileStream(XmlFilePath, FileMode.Open))
            {
                var serializer = new XmlSerializer(typeof(XmlModels.Ranklist));

                var ranklist = (XmlModels.Ranklist)serializer.Deserialize(fileStream);
                var channels = ranklist.Channels.ToList();

                var channelsToAdd = new List<Models.Channel>();
                var ownersToAdd = new List<Models.Owner>();
                var corporationsToAdd = new List<Models.Authorities.Corporation>();
                var countriesToAdd = new List<Models.Country>();
                var sponsorsToAdd = new List<Models.Authorities.Sponsor>();

                foreach (XmlModels.Channel ch in channels)
                {
                    var dbCorporationOwner = this.Database.Owners.GetAll().Where(x => x.FirstName == ch.Corporation.Owner.FirstName &&
                    x.LastName == ch.Corporation.Owner.LastName).FirstOrDefault();

                    if (dbCorporationOwner == null)
                    {
                        dbCorporationOwner = this.ModelMapper.CreateOwner(
                                ch.Corporation.Owner.FirstName,
                                ch.Corporation.Owner.LastName,
                                ch.Corporation.Owner.NetWorth
                                );

                        ownersToAdd.Add(dbCorporationOwner);
                    }

                    var dbChannelCountry = this.Database.Countries.GetAll().Where(x => x.Name == ch.Country.Name).FirstOrDefault();

                    if (dbChannelCountry == null)
                    {
                        dbChannelCountry = this.ModelMapper.CreateCountry(ch.Country.Name);

                        countriesToAdd.Add(dbChannelCountry);
                    }

                    var dbChannelSponsors = new List<Sponsor>();

                    foreach (var sp in ch.Sponsors)
                    {
                        if (!this.ContainsSponsor(sp.Name))
                        {
                            dbChannelSponsors.Add(this.ModelMapper.CreateSponsor(sp.Name, sp.About));
                        }
                    }

                    sponsorsToAdd.AddRange(dbChannelSponsors);


                    var dbCorporation = this.Database.Corporations.GetAll().Where(x => x.Name == ch.Corporation.Name).FirstOrDefault();

                    if (dbCorporation == null)
                    {
                        dbCorporation = this.ModelMapper.CreateCorporation(
                                 ch.Corporation.Name,
                                 dbCorporationOwner);

                        corporationsToAdd.Add(dbCorporation);
                    }

                    var dbchannel = this.Database.Channels.GetAll().Where(x => x.Name == ch.Name).FirstOrDefault();

                    if (dbchannel == null)
                    {
                        channelsToAdd.Add(
                            this.ModelMapper.CreateChannel(
                                ch.Name,
                                dbCorporation,
                                dbChannelCountry,
                                dbChannelSponsors
                                )
                            );
                    }
                }

                this.Database.Context.Owners.AddRange(ownersToAdd);
                this.Database.Context.Countries.AddRange(countriesToAdd);
                this.Database.Context.Corporations.AddRange(corporationsToAdd);
                this.Database.Context.Sponsors.AddRange(sponsorsToAdd);
                this.Database.Context.Channels.AddRange(channelsToAdd);

                this.Database.Commit();
            }
        }

        private bool ContainsSponsor(string sponsorName)
        {
            return this.Database.Sponsors.GetAll().Where(x => x.Name == sponsorName) != null;
        }
    }
}
