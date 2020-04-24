using IBM.Data.Informix;
using MvcAspNetInformix.Models;
using System.Collections.Generic;


namespace MvcAspNetInformix.DbConnection.ConnectionInfrmx
{
    public class ConnectionInformix : IConnectionInfmxGetData, IConnectionInfmxEditTable
    {
        ICommandIfxParams commandIfxParams;
        IfxConnection myConnection;
        IfxCommand ifxCommand;
        IfxDataReader ifxDataReader;
        ResulResponse resulResponse = new ResulResponse();

        IList<List<string>> listcolumn = new List<List<string>>();

        string sql ="";
        public ConnectionInformix(ICommandIfxParams commandIfxParams)
        {
            this.commandIfxParams = commandIfxParams;
        }
        public void CreateConnection(string configuration, string sql)
        {
            this.sql = sql;


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
        public ResulResponse EditTable(SqlResult sqlResult)
        {
            ifxCommand = new IfxCommand(sql, myConnection);

            commandIfxParams.CreateParams(ifxCommand, sqlResult);

            int res = ifxCommand.ExecuteNonQuery();
            if(res == 1)
            {                
                resulResponse.success = true;
                resulResponse.message = "Операция выполнена";
                return resulResponse;
            }
            else
            {                
                resulResponse.success = false;
                resulResponse.message = "Ошибка! Операция не выполнена";
                return resulResponse;
            }
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