using ChannelRankings.Models;
using ChannelRankings.Models.Authorities;
using ChannelRankins.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelRankings.Utils
{
    public class DbManipulationManager : IDbManipulationManager
    {
        private ISqlServerDatabase database;
        private IRepository<Channel> channels;
        private IRepository<Owner> owners;
        private IRepository<Sponsor> sponsors;
        private IRepository<Country> countries;

        public DbManipulationManager(ISqlServerDatabase database, IRepository<Owner> owners, IRepository<Sponsor> sponsors,
            IRepository<Channel> channels, IRepository<Country> countries)
        {
            this.database = database;
            this.owners = owners;
            this.sponsors = sponsors;
            this.channels = channels;
            this.countries = countries;
        }

        public void AddOwnerToDb(string firstName, string lastName, string netWorth)
        {
            if (netWorth.Any(c => !char.IsDigit(c)))
            {
                // Use Bytes2you to validate and throw error which will be caught by a try catch in wpf client
            }
            else
            {
                this.owners.Add(new Owner()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    NetWorth = netWorth
                });

                this.database.Commit();
            }
        }

        public void AddSponsorToDb(string name, string description)
        {
            this.sponsors.Add(new Sponsor()
            {
                Name = name,
                About = description
            });

            this.database.Commit();
        }

        public void UpdateChannel(int channelId, string newChannelName, string newChannelRankplace)
        {
            var channelToUpdate = this.channels.GetById(channelId);

            var newName = string.IsNullOrEmpty(newChannelName) ? channelToUpdate.Name : newChannelName;
            var newRankplace = string.IsNullOrEmpty(newChannelRankplace) ?
                channelToUpdate.WorldRankplace : int.Parse(newChannelRankplace);

            channelToUpdate.Name = newName;
            channelToUpdate.WorldRankplace = newRankplace;
            channelToUpdate.Country = channelToUpdate.Country;

            this.channels.Update(channelToUpdate);
            this.database.Commit();
        }

        public void UpdateCountry(int countryId, string newCountryName)
        {
            var countryToUpdate = this.countries.GetById(countryId);

            var newName = string.IsNullOrEmpty(newCountryName) ? countryToUpdate.Name : newCountryName;

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
