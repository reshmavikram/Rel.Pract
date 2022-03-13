using Rel.Pract.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Rel.Pract.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class PractPageModel : AbpPageModel
{
    protected PractPageModel()
    {
        LocalizationResourceType = typeof(PractResource);
    }
}
