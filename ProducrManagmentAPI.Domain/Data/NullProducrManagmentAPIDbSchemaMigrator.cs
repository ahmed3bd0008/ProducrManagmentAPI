using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ProducrManagmentAPI.Data;

/* This is used if database provider does't define
 * IProducrManagmentAPIDbSchemaMigrator implementation.
 */
public class NullProducrManagmentAPIDbSchemaMigrator : IProducrManagmentAPIDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
