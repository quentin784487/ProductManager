using ProductManager.CORE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProductManager.CORE.Persistence.Mappings
{
    public class ProductMapConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(o => o.Id);

            builder.Property(o => o.Id).ValueGeneratedOnAdd().HasColumnName("Id");

            builder.Property(en => en.ProductName).HasColumnName("ProductName");

            builder.Property(en => en.ProductCode).HasColumnName("ProductCode");
        }
    }
}
