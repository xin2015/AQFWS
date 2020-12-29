using AQFWS.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AQFWS.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AQFWSPageModel : AbpPageModel
    {
        protected AQFWSPageModel()
        {
            LocalizationResourceType = typeof(AQFWSResource);
        }
    }
}