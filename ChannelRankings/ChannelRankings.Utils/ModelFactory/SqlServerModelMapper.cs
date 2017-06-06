using ChannelRankings.Models;
using ChannelRankings.Models.Authorities;
using ChannelRankins.Contracts.Data;
using ChannelRankins.Contracts.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelRankings.Utils.ModelFactory
{
    public class SqlServerModelMapper
    {
        private IChannelModelMapper modelMapper;
        private ISqlServerDatabase database;

        public SqlServerModelMapper(IChannelModelMapper modelMapper, ISqlServerDatabase database)
        {
            this.ModelMapper = modelMapper;
            this.Database = database;
        }

        protected IChannelModelMapper ModelMapper { get; set; }

        protected ISqlServerDatabase Database { get; set; }

        //public Channel CreateChannel(string name, Corporation corporation, Country country, ICollection<Sponsor> sponsors)
        //{
        //    if (this.Database.Corporations.GetById(corporation.Id) == null)
        //    {
        //        corporation = this.Database.
        //    }

        //    var channel = modelMapper.CreateChannel()
        //}

        public Owner CreateOwner(string firstName, string lastName, string netWorth)
        {
            return modelMapper.CreateOwner(firstName, lastName, netWorth);
        }

        public Corporation CreateCorporation(string name, Owner owner)
        {
            return modelMapper.CreateCorporation(name, owner);
        }

        public Sponsor CreateSponsor(string name, string about)
        {
            return modelMapper.CreateSponsor(name, about);
        }

        public Country CreateCountry(string name)
        {
            return modelMapper.CreateCountry(name);
        }
    }
}
