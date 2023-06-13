using ExtensionManager.Core.Generics;
using ExtensionManager.Core.Models;

namespace SampleExtension;

internal class SampleFormatService : IFormatService
{
    private IFileHandle? _file;

    public bool IsValid(IFileHandle handle)
    {
        throw new NotImplementedException();
    }

    public void Read(IFileHandle handle)
    {
        Console.WriteLine($"SampleService read '{handle.Path}'");
        _file = handle;
    }

    public IFileHandle Write()
    {
        Console.WriteLine($"SampleService wrote '{_file?.Path}'");
        return null!;
    }
}
