using Rel.Pract.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Rel.Pract;

[DependsOn(
    typeof(PractEntityFrameworkCoreTestModule)
    )]
public class PractDomainTestModule : AbpModule
{

}
