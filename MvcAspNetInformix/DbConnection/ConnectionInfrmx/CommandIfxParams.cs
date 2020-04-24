using IBM.Data.Informix;
using MvcAspNetInformix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAspNetInformix.DbConnection.ConnectionInfrmx
{
    public class CommandIfxParams : ICommandIfxParams
    {
        IfxCommand ifxCommand;
        SqlResult sqlResult;
        public void CreateParams(IfxCommand ifxCommand, SqlResult sqlResult)
        {
            this.ifxCommand = ifxCommand;
            this.sqlResult = sqlResult;

            string[] sql = sqlResult.sql.Split(new char[] { ' ' });

            if (sql[0] == "INSERT")
            {
                CreateColumnCreateParams();
            }
            if (sql[0] == "UPDATE")
            {
                UpdateColumnCreateParams();
            }
            if (sql[0] == "DELETE")
            {
                DeleteColumnCreateParams();
            }
        }
        void CreateColumnCreateParams()
        {
            ifxCommand.Parameters.Add("@Surname", sqlResult.ParamsUsers.surname);
            ifxCommand.Parameters.Add("@Name", sqlResult.ParamsUsers.name);
            ifxCommand.Parameters.Add("@PatronymicName", sqlResult.ParamsUsers.patronymicName);
        }
        void UpdateColumnCreateParams()
        {
            ifxCommand.Parameters.Add("@Surname", sqlResult.ParamsUsers.surname);
            ifxCommand.Parameters.Add("@Name", sqlResult.ParamsUsers.name);
            ifxCommand.Parameters.Add("@PatronymicName", sqlResult.ParamsUsers.patronymicName);
            ifxCommand.Parameters.Add("@Id", sqlResult.ParamsUsers.id);
        }
        void DeleteColumnCreateParams()
        {
            ifxCommand.Parameters.Add("@Id", sqlResult.ParamsUsers.id);
        }
    }
}