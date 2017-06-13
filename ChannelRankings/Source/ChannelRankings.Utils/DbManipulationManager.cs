using ChannelRankings.Models;
using ChannelRankings.Models.Authorities;
using ChannelRankins.Contracts.Data;
using ChannelRankins.Contracts.Utils;
using System.Linq;

namespace ChannelRankings.Utils
{
    public class DbManipulationManager : IDbManipulationManager
    {
        private ISqlServerDatabase database;
        private IValidator validator;
        private IRepository<Channel> channels;
        private IRepository<Owner> owners;
        private IRepository<Sponsor> sponsors;
        private IRepository<Country> countries;

        public DbManipulationManager(ISqlServerDatabase database, IValidator validator, IRepository<Owner> owners, IRepository<Sponsor> sponsors,
            IRepository<Channel> channels, IRepository<Country> countries)
        {
            this.database = database;
            this.validator = validator;
            this.owners = owners;
            this.sponsors = sponsors;
            this.channels = channels;
            this.countries = countries;
        }

        public void AddOwnerToDb(string firstName, string lastName, string netWorth)
        {
            if (this.owners.GetAll().Where(x => x.FirstName == firstName && x.LastName == lastName).FirstOrDefault() == null)
            {
                this.owners.Add(new Owner()
                {
                    FirstName = this.validator.ValidateCreationName(firstName),
                    LastName = this.validator.ValidateCreationName(lastName),
                    NetWorth = this.validator.ValidateNumberValue(netWorth)
                });

                this.database.Commit();
            }
        }

        public void AddSponsorToDb(string name, string description)
        {
            if (this.sponsors.GetAll().Where(x => x.Name == name && x.About == description).FirstOrDefault() == null)
            {
                this.sponsors.Add(new Sponsor()
                {
                    Name = this.validator.ValidateCreationName(name),
                    About = description
                });

                this.database.Commit();
            }
        }

        public void UpdateChannel(int channelId, string newChannelName, string newChannelRankplace)
        {
            var channelToUpdate = this.channels.GetById(channelId);

            var newName = string.IsNullOrEmpty(newChannelName) ? channelToUpdate.Name : this.validator.ValidateNameForUpdate(newChannelName);
            var newRankplace = string.IsNullOrEmpty(newChannelRankplace) ?
                channelToUpdate.WorldRankplace : int.Parse(this.validator.ValidateNumberValue(newChannelRankplace));

            channelToUpdate.Name = newName;
            channelToUpdate.WorldRankplace = newRankplace;
            channelToUpdate.Country = channelToUpdate.Country;

            this.channels.Update(channelToUpdate);
            this.database.Commit();
        }

        public void UpdateCountry(int countryId, string newCountryName)
        {
            var countryToUpdate = this.countries.GetById(countryId);

            var newName = string.IsNullOrEmpty(newCountryName) ? countryToUpdate.Name : this.validator.ValidateNameForUpdate(newCountryName);

            countryToUpdate.Name = newName;

            this.countries.Update(countryToUpdate);
            this.database.Commit();
        }

        public void DeleteOwner(int deleteModelId)
        {
            var ownerToDelete = this.owners.GetById(deleteModelId);
            this.owners.Delete(ownerToDelete);

            this.database.Commit();
        }

        public void DeleteCountry(int deleteModelId)
        {
            var countryToDelete = this.countries.GetById(deleteModelId);
            this.countries.Delete(countryToDelete);

            this.database.Commit();
        }
    }
}
