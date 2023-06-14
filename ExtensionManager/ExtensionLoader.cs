using ExtensionManager.Core;
using System.Reflection;

namespace ExtensionManager;

public class ExtensionLoader
{
    private const string SampleExtensionPath = "F:\\VisualStudio\\Testing\\Common\\ExtensionManager\\SampleExtension\\bin\\Debug\\net7.0";
    public static void Load()
    {
        foreach (var file in Directory.GetFiles(SampleExtensionPath, "*.dll", SearchOption.TopDirectoryOnly)) {
            PluginLoadContext loader = new(file);
            Assembly asm = loader.LoadFromAssemblyName(new(Path.GetFileNameWithoutExtension(file)));
            foreach (var type in asm.GetExportedTypes().Where(x => x.GetInterface("IServiceExtension") == typeof(IServiceExtension))) {
                IServiceExtension service = (IServiceExtension)Activator.CreateInstance(type)!;
                service.RegisterExtension(API.ServiceMgr);
            }
        }
    }
}
