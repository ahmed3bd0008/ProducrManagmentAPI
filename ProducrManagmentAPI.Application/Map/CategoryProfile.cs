using AutoMapper;
using ProducrManagmentAPI.ContractApplication.Category;
using ProducrManagmentAPI.Domain.Categories;

namespace ProducrManagmentAPI.Map;
public class CategoryProfile:Profile
{
    public CategoryProfile()
    {
            CreateMap<Category,CategoryDto>().ReverseMap();
            CreateMap<Category,CreateUpdateCategoryDto>().ReverseMap();
            CreateMap<CategoryDto, CreateUpdateCategoryDto>().ReverseMap();
    }
}
