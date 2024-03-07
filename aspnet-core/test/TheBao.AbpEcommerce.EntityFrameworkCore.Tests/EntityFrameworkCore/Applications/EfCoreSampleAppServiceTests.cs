using TheBao.AbpEcommerce.Samples;
using Xunit;

namespace TheBao.AbpEcommerce.EntityFrameworkCore.Applications;

[Collection(AbpEcommerceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AbpEcommerceEntityFrameworkCoreTestModule>
{

}
