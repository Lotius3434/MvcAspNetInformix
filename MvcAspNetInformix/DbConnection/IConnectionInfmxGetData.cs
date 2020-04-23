using System.Collections.Generic;

namespace MvcAspNetInformix.DbConnection
{
    public interface IConnectionInfmxGetData
    {
        void CreateConnection(string configuration, string sql);
        IList<List<string>> GetDataReader();
        void OpenConnection();
        void CloseConnection();
    }
}
