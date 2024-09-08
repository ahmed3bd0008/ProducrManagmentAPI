using ProducrManagmentAPI.Domain.Categories;
using Volo.Abp.Domain.Entities;

namespace ProducrManagmentAPI.Domain.Products;
public class ProductCategory:Entity<int>
{
    public ProductCategory(int CategoryId)
    {
      this.CategoryId = CategoryId;
    }
    public int ProducId { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public Product Product { get; set; }
}
