using MvcAspNetInformix.Models;
using System.Collections.Generic;

namespace MvcAspNetInformix.DbConnection
{
    public class MasterConnection : IMasterConnection
    {
        IConfigurationParser configuration;
        IConnectionInformix connectionInformix;
        List<Users> users = new List<Users>();
        IList<List<string>> listcolumn;

        public MasterConnection(IConnectionInformix connectionInformix, IConfigurationParser configuration)
        {

            this.connectionInformix = connectionInformix;
            this.configuration = configuration;
        }
        public List<Users> GetDataTable()
        {
            configuration.ParseConfiguration();

            connectionInformix.CreateConnection(configuration.nameTable, configuration.configurationConnect);
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
    }
}