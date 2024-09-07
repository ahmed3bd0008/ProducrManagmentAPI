using Volo.Abp.Application.Dtos;

namespace ProducrManagmentAPI.ContractApplication.Category;
public class CategoryDto: FullAuditedEntityWithUserDto<int>
{
    public string Name { get; set; }

}
public class CreateUpdateCategoryDto : EntityDto<int>
{
    public string Name { get; set; }

}