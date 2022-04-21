using Autofac;
using Pfe.DotNetConf.Core.Interfaces;
using Pfe.DotNetConf.Core.Services;

namespace Pfe.DotNetConf.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}
