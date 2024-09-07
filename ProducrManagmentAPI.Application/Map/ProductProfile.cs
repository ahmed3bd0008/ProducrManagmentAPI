using AutoMapper;
using ProducrManagmentAPI.ContractApplication.Product;
using ProducrManagmentAPI.Domain.Categories;
using ProducrManagmentAPI.Domain.Products;
using System.Linq;

namespace ProducrManagmentAPI.Map;
public class ProductProfile:Profile
{
    public ProductProfile()
    {
            CreateMap<Product,ProductDto>().ReverseMap();
        CreateMap<CreateUpdatProductDto, Product>()
             .ForMember(dest => dest.ProductCategories, opt => opt.Ignore()) // Ignore initially
             .AfterMap((src, dest) =>
             {
                 // Map CategoryIds to ProductCategories after mapping the rest
                 dest.ProductCategories = src.category
                     .Select(categoryId => new ProductCategory ( categoryId.Id ))
                     .ToList();
             });
        CreateMap<Product, ProductDto>()
    .ForMember(dest => dest.category, opt => opt.MapFrom(src =>
        src.ProductCategories.Select(pc => pc.Category).ToList() // Map ProductCategories to List<CategoryDto>
    ));

        CreateMap<ProductDto, CreateUpdatProductDto>().ReverseMap();
    }
}
