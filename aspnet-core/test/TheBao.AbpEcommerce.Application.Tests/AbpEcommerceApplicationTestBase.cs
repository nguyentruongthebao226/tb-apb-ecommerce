using Volo.Abp.Modularity;

namespace TheBao.AbpEcommerce;

public abstract class AbpEcommerceApplicationTestBase<TStartupModule> : AbpEcommerceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
