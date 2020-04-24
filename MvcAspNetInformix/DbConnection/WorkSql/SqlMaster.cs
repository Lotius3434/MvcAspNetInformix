using MvcAspNetInformix.Models;

namespace MvcAspNetInformix.DbConnection.WorkSql
{
    public class SqlMaster : ISqlMaster
    {
        string NameTable = "table_users";

        
        public string GetAllColumn()
        {
            string sql = "Select* FROM  " + NameTable;
            return sql;
        }
        public SqlResult CreateColumn(string surnameText, string nameText, string patronymicNameText)
        {
            

            string sql = "INSERT INTO " + NameTable + " (surname, name, patronymicName)"+
                         "VALUES (?,?,?)";

            SqlResult sqlResult = new SqlResult();
            sqlResult.sql = sql;

            ParamsUsers paramsUsers = new ParamsUsers();
            paramsUsers.surname = surnameText;
            paramsUsers.name = nameText;
            paramsUsers.patronymicName = patronymicNameText;

            sqlResult.ParamsUsers = paramsUsers;
            return sqlResult;
        }
        public SqlResult UpdateColumn(int id, string surnameText, string nameText, string patronymicNameText)
        {            
            string sql = "UPDATE " + NameTable + " SET (surname, name, patronymicName) = " +
                         "(?,?,?)" +
                         "WHERE id = ?";

            SqlResult sqlResult = new SqlResult();
            sqlResult.sql = sql;

            ParamsUsers paramsUsers = new ParamsUsers();
            paramsUsers.id = id;
            paramsUsers.surname = surnameText;
            paramsUsers.name = nameText;
            paramsUsers.patronymicName = patronymicNameText;

            sqlResult.ParamsUsers = paramsUsers;
            return sqlResult;
        }
        public SqlResult DeleteColumn(int id)
        {
            string sql = "DELETE FROM " + NameTable + " WHERE id = ?";

            SqlResult sqlResult = new SqlResult();
            sqlResult.sql = sql;

            ParamsUsers paramsUsers = new ParamsUsers();
            paramsUsers.id = id;

            sqlResult.ParamsUsers = paramsUsers;
            return sqlResult;
        }
        
    }
}