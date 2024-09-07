using ProducrManagmentAPI.Domain.Products;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace ProducrManagmentAPI.Domain.Categories;
public class Category:FullAuditedEntity<int>
{
    public string Name { get; set; }
    public List<ProductCategory> ProductCategories { get; set; }

}
