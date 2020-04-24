using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using MvcAspNetInformix.DbConnection;
using MvcAspNetInformix.DbConnection.ConnectionInfrmx;
using MvcAspNetInformix.DbConnection.ParsingConfiguration;
using MvcAspNetInformix.DbConnection.WorkSql;

namespace MvcAspNetInformix
{
    public class CastleWidsorConfiguration : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IMasterGetDataTable>().ImplementedBy<MasterConnection>().LifestyleTransient().Named("IMasterGetDataTable"));
            container.Register(Component.For<IMasterEditDataTable>().ImplementedBy<MasterConnection>().LifestyleTransient().Named("IMasterEditDataTable"));
            container.Register(Component.For<IConfigurationParser>().ImplementedBy<ConfigurationParser>().LifestyleTransient());
            container.Register(Component.For<IConnectionInfmxGetData>().ImplementedBy<ConnectionInformix>().LifestyleTransient().Named("IConnectionInfmxGetData"));
            container.Register(Component.For<IConnectionInfmxEditTable>().ImplementedBy<ConnectionInformix>().LifestyleTransient().Named("IConnectionInfmxEditTable"));
            container.Register(Component.For<ISqlMaster>().ImplementedBy<SqlMaster>().LifestyleTransient());
            container.Register(Component.For<ICommandIfxParams>().ImplementedBy<CommandIfxParams>().LifestyleTransient());       
        }
    }
}