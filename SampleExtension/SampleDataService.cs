using ExtensionManager.Core.Generics;
using ExtensionManager.Core.Models;

namespace SampleExtension;

internal class SampleDataService : IDataService
{
    public bool IsValid(IFileHandle handle)
    {
        return handle.Path.EndsWith(".zs");
    }

    public IFileHandle Process(IFileHandle handle)
    {
        handle.Path = handle.Path[..^3];
        return handle;
    }

    public IFileHandle Reprocess(IFileHandle handle)
    {
        handle.Path += ".zs";
        return handle;
    }
}
