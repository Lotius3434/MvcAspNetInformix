namespace MvcAspNetInformix.DbConnection
{
    public interface IConfigurationParser
    {
        string configurationConnect { get; }
        void ParseConfiguration();
    }
}
