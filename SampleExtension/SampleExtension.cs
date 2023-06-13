using ExtensionManager.Core;

namespace SampleExtension;

public class SampleExtension : IServiceExtension
{
    public string Name { get; } = "Sample Extension";

    public void RegisterExtension(IServiceMgr mgr)
    {
        mgr.Register(new SampleDataService());
        mgr.Register(new SampleFormatService());
    }
}
