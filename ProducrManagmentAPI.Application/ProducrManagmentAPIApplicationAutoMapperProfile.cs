using AutoMapper;
using ProducrManagmentAPI.ContractApplication.Category;
using ProducrManagmentAPI.Domain.Categories;

namespace ProducrManagmentAPI;

public class ProducrManagmentAPIApplicationAutoMapperProfile : Profile
{
    public ProducrManagmentAPIApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Category, CreateUpdateCategoryDto>().ReverseMap();
        CreateMap<CategoryDto, CreateUpdateCategoryDto>().ReverseMap();
    }
}
