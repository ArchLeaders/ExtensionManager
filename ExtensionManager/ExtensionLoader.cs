using ExtensionManager.Core;
using System.Reflection;

namespace ExtensionManager;

public class ExtensionLoader
{
    private const string SampleExtensionPath = "F:\\VisualStudio\\Testing\\Common\\ExtensionManager\\SampleExtension\\bin\\Debug\\net7.0";
    public static void Load()
    {
        foreach (var file in Directory.GetFiles(SampleExtensionPath, "*.dll", SearchOption.TopDirectoryOnly).Where(x => Path.GetFileName(x) != "ExtensionManager.Core.dll")) {
            Assembly asm = Assembly.LoadFrom(file);
            foreach (var type in asm.GetTypes().Where(x => x.GetInterface("IIServiceExtension") == typeof(IServiceExtension))) {
                IServiceExtension service = (IServiceExtension)Activator.CreateInstance(type)!;
                service.RegisterExtension(API.ServiceMgr);
            }
        }
    }
}
