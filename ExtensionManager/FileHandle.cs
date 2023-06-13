using ExtensionManager.Core.Models;

namespace ExtensionManager;

public class FileHandle : IFileHandle
{
    public byte[] Data { get; set; }
    public string Path { get; set; }

    public FileHandle(string path, byte[] data)
    {
        Path = path;
        Data = data;
    }
}
