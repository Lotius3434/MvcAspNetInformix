using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcAspNetInformix.DbConnection
{
    public interface IConfigurationParser
    {
        string configurationConnect { get; }
        string nameTable { get; }
        void ParseConfiguration();
    }
}
