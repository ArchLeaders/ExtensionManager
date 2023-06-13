using ExtensionManager.Core.Generics;
using ExtensionManager.Core.Models;

namespace ExtensionManager.Core;

public interface IServiceMgr
{
    public void RequestService(IFileHandle handle);
    public void Register(IDataService dataProcessor);
    public void Register(IFormatService formatService);
}
