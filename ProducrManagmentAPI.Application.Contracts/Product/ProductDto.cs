using ProducrManagmentAPI.ContractApplication.Category;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace ProducrManagmentAPI.ContractApplication.Product;
public class ProductDto: FullAuditedEntityWithUserDto<int>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public  List<CategoryDto> category { get; set; }
}
public class CreateUpdatProductDto : EntityDto<int>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public List<CreateUpdateCategoryDto> category { get; set; }

}