using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProducrManagmentAPI.Domain.Categories;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ProducrManagmentAPI.Configuration;
internal class CategoryConfigure : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ConfigureByConvention();
        builder.Property(p => p.Name).IsRequired();
        builder.HasMany(p=>p.ProductCategories).WithOne(p => p.Category).HasForeignKey(p=>p.CategoryId);
    }
}
