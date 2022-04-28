using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Components;

namespace ProjectTemplate.WebAssembly.Layouts
{
    public class ProjectTemplateLayout: AbpComponentBase
    {
        internal const string BodyPropertyName = "Body";

        //
        // 摘要:
        //     Gets the content to be rendered inside the layout.
        [Parameter]
        public RenderFragment? Body
        {
            get;
            set;
        }

        [DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof(LayoutComponentBase))]
        public override Task SetParametersAsync(ParameterView parameters)
        {
            return base.SetParametersAsync(parameters);
        }
    }
}
