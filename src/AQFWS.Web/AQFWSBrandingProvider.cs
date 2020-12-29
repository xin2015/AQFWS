using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AQFWS.Web
{
    [Dependency(ReplaceServices = true)]
    public class AQFWSBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AQFWS";
    }
}
