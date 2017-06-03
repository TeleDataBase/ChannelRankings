using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelRankings.Models.Contracts
{
    public interface IPerson
    {
        string FirstName { get; set; }

        string LastName { get; set; }
    }
}
