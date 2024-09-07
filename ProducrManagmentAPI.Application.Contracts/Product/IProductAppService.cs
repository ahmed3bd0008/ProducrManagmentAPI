using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ProducrManagmentAPI.ContractApplication.Product;
public interface IProductAppService:IApplicationService
{

     Task<ProductDto> CreateAsync(CreateUpdatProductDto input);
     Task DeleteAsync(int id);
     Task<ProductDto> GetAsync(int id);
     Task<PagedResultDto<ProductDto>> GetListAsync(PagedAndSortedResultRequestDto input);
    Task<ProductDto> UpdateAsync(int id, CreateUpdatProductDto input);
   
}
