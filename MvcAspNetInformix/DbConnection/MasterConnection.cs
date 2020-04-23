using MvcAspNetInformix.Models;
using System.Collections.Generic;

namespace MvcAspNetInformix.DbConnection
{
    public class MasterConnection : IMasterGetDataTable , IMasterEditDataTable
    {
        IConfigurationParser configuration;
        IConnectionInfmxGetData connectionInformix;
        IConnectionInfmxEditTable connectionInfmxEditTable;
        List<Users> users = new List<Users>();
        IList<List<string>> listcolumn;

        public MasterConnection(IConnectionInfmxGetData connectionInformix, IConfigurationParser configuration , IConnectionInfmxEditTable connectionInfmxEditTable)
        {

            this.connectionInformix = connectionInformix;
            this.configuration = configuration;
            this.connectionInfmxEditTable = connectionInfmxEditTable;
        }
        public List<Users> GetDataTable(string sql)
        {
            configuration.ParseConfiguration();

            
            connectionInformix.CreateConnection(configuration.configurationConnect, sql);
            connectionInformix.OpenConnection();

            listcolumn = connectionInformix.GetDataReader();
            foreach (var column in listcolumn)
            {
                Users user = new Users();
                user.id = column[0];
                user.surname = column[1];
                user.name = column[2];
                user.patronymicName = column[3];
                users.Add(user);
            }
            connectionInformix.CloseConnection();

            return users;

        }
        public ResulResponse EditDataTable(string sql)
        {
            configuration.ParseConfiguration();

            connectionInfmxEditTable.CreateConnection(configuration.configurationConnect, sql);
            connectionInfmxEditTable.OpenConnection();

            ResulResponse result = connectionInfmxEditTable.EditTable();

            connectionInfmxEditTable.CloseConnection();
            return result;
        }
    }
}