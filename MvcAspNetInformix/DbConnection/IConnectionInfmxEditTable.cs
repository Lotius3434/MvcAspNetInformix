using MvcAspNetInformix.Models;

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
