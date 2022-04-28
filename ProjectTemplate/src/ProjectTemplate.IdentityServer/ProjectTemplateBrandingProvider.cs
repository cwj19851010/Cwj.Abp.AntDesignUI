using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ProjectTemplate;

[Dependency(ReplaceServices = true)]
public class ProjectTemplateBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ProjectTemplate";
}
