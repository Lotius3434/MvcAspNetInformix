using MvcAspNetInformix.Models;

namespace MvcAspNetInformix.DbConnection.WorkSql
{
    public interface ISqlMaster
    {
        string GetAllColumn();
        SqlResult CreateColumn(string surnameText, string nameText, string patronymicNameText);
        SqlResult UpdateColumn(int id, string surnameText, string nameText, string patronymicNameText);
        SqlResult DeleteColumn(int id);
    }
}
