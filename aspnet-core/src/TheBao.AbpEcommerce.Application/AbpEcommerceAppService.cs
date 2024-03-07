using System;
using System.Collections.Generic;
using System.Text;
using TheBao.AbpEcommerce.Localization;
using Volo.Abp.Application.Services;

namespace TheBao.AbpEcommerce;

/* Inherit your application services from this class.
 */
public abstract class AbpEcommerceAppService : ApplicationService
{
    protected AbpEcommerceAppService()
    {
        LocalizationResource = typeof(AbpEcommerceResource);
    }
}
