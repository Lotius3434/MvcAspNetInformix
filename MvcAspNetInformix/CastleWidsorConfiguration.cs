using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using MvcAspNetInformix.DbConnection;

namespace MvcAspNetInformix
{
    public class CastleWidsorConfiguration : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IMasterConnection>().ImplementedBy<MasterConnection>().LifestyleTransient());
            container.Register(Component.For<IConfigurationParser>().ImplementedBy<ConfigurationParser>().LifestyleTransient());
            container.Register(Component.For<IConnectionInfmxGetData>().ImplementedBy<ConnectionInformix>().LifestyleTransient().Named("IConnectionInfmxGetData"));
            container.Register(Component.For<IConnectionInfmxEditTable>().ImplementedBy<ConnectionInformix>().LifestyleTransient().Named("IConnectionInfmxEditTable"));
            
        }
    }
}