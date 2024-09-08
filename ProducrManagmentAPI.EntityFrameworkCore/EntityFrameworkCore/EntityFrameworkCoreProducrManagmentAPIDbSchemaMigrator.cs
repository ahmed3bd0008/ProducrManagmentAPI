using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProducrManagmentAPI.Data;
using Volo.Abp.DependencyInjection;

namespace ProducrManagmentAPI.EntityFrameworkCore;

public class EntityFrameworkCoreProducrManagmentAPIDbSchemaMigrator
    : IProducrManagmentAPIDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreProducrManagmentAPIDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ProducrManagmentAPIDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ProducrManagmentAPIDbContext>()
            .Database
            .MigrateAsync();
    }
}
