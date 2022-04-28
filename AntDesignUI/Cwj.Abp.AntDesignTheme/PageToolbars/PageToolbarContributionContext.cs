﻿using JetBrains.Annotations;
using System;
using Volo.Abp;

namespace Cwj.Abp.AntDesignTheme.PageToolbars;

public class PageToolbarContributionContext
{
    [NotNull]
    public IServiceProvider ServiceProvider { get; }

    [NotNull]
    public PageToolbarItemList Items { get; }

    public PageToolbarContributionContext(
        [NotNull] IServiceProvider serviceProvider)
    {
        ServiceProvider = Check.NotNull(serviceProvider, nameof(serviceProvider));
        Items = new PageToolbarItemList();
    }
}
