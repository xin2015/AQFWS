using System;
using System.Collections.Generic;
using System.Text;
using AQFWS.Localization;
using Volo.Abp.Application.Services;

namespace AQFWS
{
    /* Inherit your application services from this class.
     */
    public abstract class AQFWSAppService : ApplicationService
    {
        protected AQFWSAppService()
        {
            LocalizationResource = typeof(AQFWSResource);
        }
    }
}
