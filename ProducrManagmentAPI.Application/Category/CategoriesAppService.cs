using ProducrManagmentAPI.ContractApplication.Category;
using ProducrManagmentAPI.ContractApplication.Product;
using ProducrManagmentAPI.Domain.Categories;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ProducrManagmentAPI.Application.CategoriesAppService;
public class CategoriesAppService : CrudAppService<Category, CategoryDto, int, PagedAndSortedResultRequestDto, CreateUpdateCategoryDto>, ICategoriesAppService
{
    //private readonly IRepository<Category, int> _repository;

    public CategoriesAppService(IRepository<Category, int> repository) : base(repository)
    {
    }

   
  

    
  

    //public CategoriesAppService(IRepository<Category, int> repository) 
    //{

    //    _repository = repository;
    //}

    //public  async Task<CategoryDto> CreateAsync(CreateUpdateCategoryDto input)
    //{
    //    var category = ObjectMapper.Map<CreateUpdateCategoryDto,Category>(input);
    //    await _repository.InsertAsync(category);
    //    return ObjectMapper.Map<Category,CategoryDto>(category);

    //}

    //public Task DeleteAsync(int id)
    //{
    //    throw new System.NotImplementedException();
    //}

    //public Task<CategoryDto> GetAsync(int id)
    //{
    //    throw new System.NotImplementedException();
    //}

    //public async Task<PagedResultDto<CategoryDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    //{
    //    var cats = await _repository.GetListAsync();
    //    return new PagedResultDto<CategoryDto>() { TotalCount = 10 };

    //}

    //public Task<CategoryDto> UpdateAsync(int id, CreateUpdateCategoryDto input)
    //{
    //    throw new System.NotImplementedException();
    //}
}
