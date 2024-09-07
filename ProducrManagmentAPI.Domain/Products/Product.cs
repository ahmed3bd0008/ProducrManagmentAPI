using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace ProducrManagmentAPI.Domain.Products;
public class Product:FullAuditedEntity<int>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public List<ProductCategory>ProductCategories { get; set; }
}
