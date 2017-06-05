using ChannelRankins.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelRankins.Contracts.Utils
{
    public interface IXmlImporter
    {
        void Import(ISqlServerDatabase connection);
    }
}
