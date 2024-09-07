using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProducrManagmentAPI.Domain.Products;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ProducrManagmentAPI.Configuration;
internal class ProductConfigure : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ConfigureByConvention();
        builder.Property(p => p.Name).IsRequired();
        builder.Property(p => p.Price)
            .HasColumnType("decimal(18,2)")
            .HasDefaultValue(0.01M)
            .IsRequired();
        builder.HasMany(p => p.ProductCategories).WithOne(p => p.Product).HasForeignKey(p => p.ProducId);

    }
}
