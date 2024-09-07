using ProducrManagmentAPI.ContractApplication.Category;
using ProducrManagmentAPI.ContractApplication.Product;
using ProducrManagmentAPI.Domain.Products;
using ProducrManagmentAPI.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ProducrManagmentAPI.Application.ProductAppService;
public class ProductAppService :ApplicationService, IProductAppService
{
    private readonly IRepository<Product, int> _repository;
    private readonly IProductRepository _productRepository;

    public ProductAppService(IRepository<Product, int> repository, IProductRepository productRepository) 
    {
        _repository = repository;
        _productRepository = productRepository;
    }


    public async Task<ProductDto> CreateAsync(CreateUpdatProductDto input)
    {
        var product = ObjectMapper.Map<CreateUpdatProductDto,Product>(input);
        await _repository.InsertAsync(product);
        return ObjectMapper.Map<Product, ProductDto>(product);
    }

    public Task DeleteAsync(int id)
    {
        throw new System.NotImplementedException();
    }

    public async Task<ProductDto> GetAsync(int id)
    {
        var product =await _repository.GetAsync(id);
        return ObjectMapper.Map<Product,ProductDto>(product);
    }

    public async Task<PagedResultDto<ProductDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        var product = await _repository.GetListAsync(true);
        var products = await _productRepository.GetListAsync();
        return new PagedResultDto<ProductDto>() { Items= ObjectMapper.Map<List<Product>, List<ProductDto>>(products) };
    }

    public Task<ProductDto> UpdateAsync(int id, CreateUpdatProductDto input)
    {
        throw new System.NotImplementedException();
    }
}
