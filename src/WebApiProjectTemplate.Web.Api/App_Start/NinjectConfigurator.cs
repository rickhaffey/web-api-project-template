using log4net.Config;
using Ninject;
using WebApiProjectTemplate.Common;
using WebApiProjectTemplate.Common.Logging;
 
namespace WebApiProjectTemplate.Web.Api
{
    public class NinjectConfigurator
    {
        public void Configure(IKernel container)
        {
            AddBindings(container);
        }
 
        private void AddBindings(IKernel container)
        {
            ConfigureLog4net(container);
 
            container.Bind<IDateTime>().To<DateTimeAdapter>().InSingletonScope();
        }
 
        private void ConfigureLog4net(IKernel container)
        {
            XmlConfigurator.Configure();
 
            var logManager = new LogManagerAdapter();
            container.Bind<ILogManager>().ToConstant(logManager);
        }
    }
}