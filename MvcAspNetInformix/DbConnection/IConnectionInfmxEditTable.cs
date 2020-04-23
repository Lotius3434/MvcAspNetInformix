using MvcAspNetInformix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcAspNetInformix.DbConnection
{
    public interface IConnectionInfmxEditTable
    {
        void CreateConnection(string configuration, string sql);
        ResulResponse EditTable();
        void OpenConnection();
        void CloseConnection();
    }
}
