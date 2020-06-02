using oligoCode.ToDo.Shell.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace oligoCode.ToDo.Shell
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
