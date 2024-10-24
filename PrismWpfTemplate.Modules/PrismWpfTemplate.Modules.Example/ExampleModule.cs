using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismWpfTemplate.Core;
using PrismWpfTemplate.Core.Interfaces;
using PrismWpfTemplate.Modules.Example.Services;

namespace PrismWpfTemplate.Modules.Example;

public class ExampleModule(IRegionManager regionManager) : IModule
{
    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.Register<IMessageService, MessageService>();
        regionManager.RegisterViewWithRegion<Views.Example>(RegionNames.MainRegion);
    }

    public void OnInitialized(IContainerProvider containerProvider)
    {
        regionManager.RequestNavigate(RegionNames.MainRegion, nameof(Views.Example));
    }
}