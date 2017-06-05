using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelRankings.Models.Contracts
{
    public interface IOwner
    {
        int Id { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string NetWorth { get; set; }

        ICollection<ICorporation> Corporations{ get; set; }
    }
}
