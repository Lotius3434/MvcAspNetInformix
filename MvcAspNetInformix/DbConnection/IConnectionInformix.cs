using System.Collections.Generic;


namespace MvcAspNetInformix.DbConnection
{
    public interface IConnectionInformix
    {
        void CreateConnection(string nametable, string configuration);
        IList<List<string>> GetDataReader();
        void OpenConnection();
        void CloseConnection();
    }
}
