using oligoCode.ToDo.ToDoItemModule;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System;
using System.Windows;

namespace oligoCode.ToDo.Shell
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App: PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            Type ToDoItemModuleType = typeof(ToDoItemModule.ToDoItemModule);
            moduleCatalog.AddModule(new ModuleInfo()
            {
                ModuleName = ToDoItemModuleType.Name,
                ModuleType = ToDoItemModuleType.AssemblyQualifiedName
            });
        }
    }
}
