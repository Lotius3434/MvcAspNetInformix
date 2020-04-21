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
            container.Register(Component.For<IMasterConnection>().ImplementedBy<MasterConnection>());
            container.Register(Component.For<IConfigurationParser>().ImplementedBy<ConfigurationParser>());
            container.Register(Component.For<IConnectionInformix>().ImplementedBy<ConnectionInformix>());
        }
    }
}