using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ProducrManagmentAPI;

[Dependency(ReplaceServices = true)]
public class ProducrManagmentAPIBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ProducrManagmentAPI";
}
