using ExtensionManager.Core;

namespace ExtensionManager;

public class API
{
    public static IServiceMgr ServiceMgr { get; } = new ServiceMgr();

    /// <summary>
    /// Passes the provided <paramref name="param"/>
    /// to the loaded extension processor
    /// </summary>
    /// <param name="param"></param>
    public static void Process(string param)
    {
        Console.WriteLine($"API processing '{param}' | (Top Level)");
        API.ServiceMgr.RequestService(new FileHandle(param, Array.Empty<byte>()));
    }
}
