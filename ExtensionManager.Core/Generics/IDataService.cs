using ExtensionManager.Core.Models;

namespace ExtensionManager.Core.Generics;

public interface IDataService : IServiceModule
{
    /// <summary>
    /// Converts processed data to raw data and returns the result
    /// </summary>
    /// <param name="handle"></param>
    /// <returns></returns>
    public IFileHandle Process(IFileHandle handle);

    /// <summary>
    /// Reprocesses raw data and returns the result
    /// </summary>
    /// <param name="handle"></param>
    /// <returns></returns>
    public IFileHandle Reprocess(IFileHandle handle);
}
