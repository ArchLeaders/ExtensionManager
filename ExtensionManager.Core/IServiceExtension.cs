namespace ExtensionManager.Core;

/// <summary>
/// Metadata used when registering the extension
/// </summary>
public interface IServiceExtension
{
    public string Name { get; }
    public void RegisterExtension(IServiceMgr mgr);
}
