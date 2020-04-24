using MvcAspNetInformix.Models;

namespace MvcAspNetInformix.DbConnection.ConnectionInfrmx
{
    public interface IConnectionInfmxEditTable
    {
        void CreateConnection(string configuration, string sql);
        ResulResponse EditTable(SqlResult sqlResult);
        void OpenConnection();
        void CloseConnection();
    }
}
