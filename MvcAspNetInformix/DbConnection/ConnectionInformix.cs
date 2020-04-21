

using IBM.Data.Informix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MvcAspNetInformix.DbConnection
{
    public class ConnectionInformix : IConnectionInformix
    {
        IfxConnection myConnection;
        IfxCommand ifxCommand;
        IfxDataReader ifxDataReader;

        IList<List<string>> listcolumn = new List<List<string>>();

        string sql = "Select * FROM ";

        public void CreateConnection(string nametable, string configuration)
        {
            sql += nametable;

            myConnection = new IfxConnection();
            myConnection.ConnectionString = configuration;
        }
        public IList<List<string>> GetDataReader()
        {
            ifxCommand = new IfxCommand(sql, myConnection);
            ifxDataReader = ifxCommand.ExecuteReader();


            while (ifxDataReader.Read())
            {
                List<string> column = new List<string>();
                column.Add(ifxDataReader["id"].ToString());
                column.Add(ifxDataReader["surname"].ToString());
                column.Add(ifxDataReader["name"].ToString());
                column.Add(ifxDataReader["patronymicName"].ToString());
                listcolumn.Add(column);
            }
            return listcolumn;
        }
        public void OpenConnection()
        {
            myConnection.Open();
        }
        public void CloseConnection()
        {
            myConnection.Close();
        }
    }
}