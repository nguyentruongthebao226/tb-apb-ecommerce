using Volo.Abp.Modularity;

namespace TheBao.AbpEcommerce;

[DependsOn(
    typeof(AbpEcommerceApplicationModule),
    typeof(AbpEcommerceDomainTestModule)
)]
public class AbpEcommerceApplicationTestModule : AbpModule
{

}
