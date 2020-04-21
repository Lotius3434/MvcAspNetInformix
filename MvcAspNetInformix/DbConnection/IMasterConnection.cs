using MvcAspNetInformix.Models;
using System.Collections.Generic;

namespace MvcAspNetInformix.DbConnection
{
    public interface IMasterConnection
    {
        List<Users> GetDataTable();
    }
}
