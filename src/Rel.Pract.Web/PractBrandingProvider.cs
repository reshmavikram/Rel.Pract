using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Rel.Pract.Web;

[Dependency(ReplaceServices = true)]
public class PractBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Pract";
}
