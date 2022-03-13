using Volo.Abp.Settings;

namespace Rel.Pract.Settings;

public class PractSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(PractSettings.MySetting1));
    }
}
