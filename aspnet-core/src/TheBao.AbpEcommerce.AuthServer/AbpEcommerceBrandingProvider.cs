﻿using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace TheBao.AbpEcommerce;

[Dependency(ReplaceServices = true)]
public class AbpEcommerceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpEcommerce";
}
