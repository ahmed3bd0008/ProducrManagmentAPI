using ProducrManagmentAPI.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ProducrManagmentAPI.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ProducrManagmentAPIEntityFrameworkCoreModule),
    typeof(ProducrManagmentAPIApplicationContractsModule)
    )]
public class ProducrManagmentAPIDbMigratorModule : AbpModule
{
}
