﻿using System;
using System.Collections.Generic;
using Volo.Abp.DependencyInjection;

// ReSharper disable once CheckNamespace
namespace Volo.Abp.SettingManagement;

public class SettingComponentCreationContext : IServiceProviderAccessor
{
    public IServiceProvider ServiceProvider { get; }

    public List<SettingComponentGroup> Groups { get; }

    public SettingComponentCreationContext(IServiceProvider serviceProvider)
    {
        ServiceProvider = serviceProvider;

        Groups = new List<SettingComponentGroup>();
    }
}

