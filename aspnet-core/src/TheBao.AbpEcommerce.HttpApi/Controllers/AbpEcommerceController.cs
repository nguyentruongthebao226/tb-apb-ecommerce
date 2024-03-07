using TheBao.AbpEcommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TheBao.AbpEcommerce.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpEcommerceController : AbpControllerBase
{
    protected AbpEcommerceController()
    {
        LocalizationResource = typeof(AbpEcommerceResource);
    }
}
