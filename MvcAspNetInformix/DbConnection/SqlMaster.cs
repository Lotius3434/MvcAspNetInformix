using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAspNetInformix.DbConnection
{
    public class SqlMaster
    {
        string NameTable = "table_users";

        
        public string GetAllColumn()
        {
            string sql = "Select* FROM  " + NameTable;
            return sql;
        }
        public string CreateColumn(string surnameText, string nameText, string patronymicNameText)
        {
            ReplaceString(ref surnameText, ref nameText, ref patronymicNameText);

            string sql = "INSERT INTO " + NameTable + " (surname, name, patronymicName)"+
                         "VALUES ('" + surnameText + "'"+", "+"'" + nameText + "'" + ", " + "'" + patronymicNameText + "') ";
            return sql;
        }
        public string UpdateColumn(int id, string surnameText, string nameText, string patronymicNameText)
        {
            ReplaceString(ref surnameText, ref nameText, ref patronymicNameText);
            
            string sql = "UPDATE "+ NameTable + " SET (surname, name, patronymicName) = " +
                         "('" + surnameText + "'"+","+"'" + nameText + "'" + "," + "'" + patronymicNameText + "') " +
                         "WHERE id =" + id.ToString();
            return sql;
        }
        public void DeleteColumn()
        {

        }
        void ReplaceString(ref string surnameText, ref string nameText, ref string patronymicNameText)
        {
            surnameText = surnameText.Replace(" ","");
            nameText = nameText.Replace(" ", "");
            patronymicNameText = patronymicNameText.Replace(" ", "");
        }
    }
}