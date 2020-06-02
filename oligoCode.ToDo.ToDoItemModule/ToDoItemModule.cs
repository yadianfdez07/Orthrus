using oligoCode.ToDo.Infrastructure;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace oligoCode.ToDo.ToDoItemModule
{
    public class ToDoItemModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            // use the containerProvider to retrieve the instance of the Prism RegionManager
            // and register the view in this module with a specific region in the app
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(ToDoItemListView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}