using Microsoft.EntityFrameworkCore;
using ProducrManagmentAPI.Domain.Products;
using ProducrManagmentAPI.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace ProducrManagmentAPI.EntityFrameworkCore.Repository;
internal class ProductRepository : EfCoreRepository<ProducrManagmentAPIDbContext, Product, int>, IProductRepository
{
    private readonly IDbContextProvider<ProducrManagmentAPIDbContext> _dbContextProvider;

    public ProductRepository(IDbContextProvider<ProducrManagmentAPIDbContext> dbContextProvider) : base(dbContextProvider)
    {
        _dbContextProvider=dbContextProvider;
    }
    public async Task<List<Product>> GetListAsync()
    {
       var Products= await _dbContextProvider.GetDbContextAsync().Result.Product.Include(p=>p.ProductCategories).ThenInclude(c=>c.Category).ToListAsync();
        return Products;
    }

}
