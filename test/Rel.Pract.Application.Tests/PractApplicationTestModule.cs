using Volo.Abp.Modularity;

namespace Rel.Pract;

[DependsOn(
    typeof(PractApplicationModule),
    typeof(PractDomainTestModule)
    )]
public class PractApplicationTestModule : AbpModule
{

}
