using AQFWS.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AQFWS.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AQFWSController : AbpController
    {
        protected AQFWSController()
        {
            LocalizationResource = typeof(AQFWSResource);
        }
    }
}