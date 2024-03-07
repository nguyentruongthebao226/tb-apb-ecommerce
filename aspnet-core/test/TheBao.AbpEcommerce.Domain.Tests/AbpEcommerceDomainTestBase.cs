using Volo.Abp.Modularity;

namespace TheBao.AbpEcommerce;

/* Inherit from this class for your domain layer tests. */
public abstract class AbpEcommerceDomainTestBase<TStartupModule> : AbpEcommerceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
