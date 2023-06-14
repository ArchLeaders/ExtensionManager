using ExtensionManager.Core.Generics;
using ExtensionManager.Core.Models;

namespace ExtensionManager.Core;

public class ServiceMgr : IServiceMgr
{
    private readonly List<IDataService> _dataServices = new();
    private readonly List<IFormatService> _formatServices = new();

    public void RequestService(IFileHandle handle)
    {
        foreach (var service in _dataServices) {
            if (service.IsValid(handle)) {
                handle = service.Process(handle);
                break;
            }
        }

        foreach (var service in _formatServices) {
            if (service.IsValid(handle)) {
                service.Read(handle);
            }
        }
    }

    public void Register(IDataService dataProcessor)
    {
        _dataServices.Add(dataProcessor);
    }

    public void Register(IFormatService formatService)
    {
        _formatServices.Add(formatService);
    }
}
