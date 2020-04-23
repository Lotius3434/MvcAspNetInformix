namespace MvcAspNetInformix.DbConnection
{
    public interface ISqlMaster
    {
        string GetAllColumn();
        string CreateColumn(string surnameText, string nameText, string patronymicNameText);
        string UpdateColumn(int id, string surnameText, string nameText, string patronymicNameText);
        string DeleteColumn(int id);
    }
}
