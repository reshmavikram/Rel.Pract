using Rel.Pract.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Rel.Pract.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PractEntityFrameworkCoreModule),
    typeof(PractApplicationContractsModule)
    )]
public class PractDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
