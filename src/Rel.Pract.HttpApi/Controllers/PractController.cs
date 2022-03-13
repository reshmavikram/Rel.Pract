using Rel.Pract.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Rel.Pract.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PractController : AbpControllerBase
{
    protected PractController()
    {
        LocalizationResource = typeof(PractResource);
    }
}
