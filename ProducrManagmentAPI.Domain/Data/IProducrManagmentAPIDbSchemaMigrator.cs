using System.Threading.Tasks;

namespace ProducrManagmentAPI.Data;

public interface IProducrManagmentAPIDbSchemaMigrator
{
    Task MigrateAsync();
}
