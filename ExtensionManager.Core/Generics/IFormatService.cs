using ExtensionManager.Core.Models;

namespace ExtensionManager.Core.Generics;

public interface IFormatService : IServiceModule
{
    /// <summary>
    /// Reads the <paramref name="handle"/> into the <see cref="IFormatService"/>
    /// </summary>
    /// <param name="handle"></param>
    public void Read(IFileHandle handle);

    /// <summary>
    /// Writes the <see cref="IFormatService"/> payload to an <see cref="IFileHandle"/> and returns the result
    /// </summary>
    /// <returns></returns>
    public IFileHandle Write();
}
