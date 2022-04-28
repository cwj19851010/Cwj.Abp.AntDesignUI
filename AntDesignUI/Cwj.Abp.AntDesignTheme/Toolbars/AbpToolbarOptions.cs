using System.Collections.Generic;
using JetBrains.Annotations;
using Cwj.Abp.AntDesignTheme.Toolbars;

namespace Cwj.Abp.AntDesignTheme.Toolbars;

public class AbpToolbarOptions
{
    [NotNull]
    public List<IToolbarContributor> Contributors { get; }

    public AbpToolbarOptions()
    {
        Contributors = new List<IToolbarContributor>();
    }
}
