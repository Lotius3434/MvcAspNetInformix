using MvcAspNetInformix.Models;
using System.Collections.Generic;

namespace MvcAspNetInformix.DbConnection
{
    public interface IMasterGetDataTable
    {
        List<Users> GetDataTable(string sql);
        
    }
}
