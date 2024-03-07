using Volo.Abp.Modularity;

namespace TheBao.AbpEcommerce;

[DependsOn(
    typeof(AbpEcommerceDomainModule),
    typeof(AbpEcommerceTestBaseModule)
)]
public class AbpEcommerceDomainTestModule : AbpModule
{

}
