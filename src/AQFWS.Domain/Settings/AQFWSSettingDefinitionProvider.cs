using Volo.Abp.Settings;

namespace AQFWS.Settings
{
    public class AQFWSSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AQFWSSettings.MySetting1));
        }
    }
}
