using ProducrManagmentAPI.Domain.Products;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace ProducrManagmentAPI.Repository;
public interface IProductRepository:IRepository<Product, int>
{
    public Task<List<Product>> GetListAsync();

}
