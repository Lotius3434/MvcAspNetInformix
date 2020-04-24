namespace MvcAspNetInformix.DbConnection.ParsingConfiguration
{
    public interface IConfigurationParser
    {
        string configurationConnect { get; }
        void ParseConfiguration();
    }
}
