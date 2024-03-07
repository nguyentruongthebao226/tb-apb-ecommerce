using TheBao.AbpEcommerce.Samples;
using Xunit;

namespace TheBao.AbpEcommerce.EntityFrameworkCore.Domains;

[Collection(AbpEcommerceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AbpEcommerceEntityFrameworkCoreTestModule>
{

}
