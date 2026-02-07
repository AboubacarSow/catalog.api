using catalog.api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace catalog.api.Data.EFCore.Configuration;


public class ProductConfig : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasIndex(p=>p.Name);
        builder.Property(p=>p.Name).IsRequired();
        builder.Property(p=>p.Price).HasPrecision(18,2);
        builder.Property(p=>p.Price).IsRequired();
        builder.Property(p=>p.Description).IsRequired();

        builder.HasOne(p=>p.Brand)
                .WithMany(b=>b.Products)
                .HasForeignKey(p=>p.BrandId);

        builder.HasOne(p=>p.Type)
                .WithMany(pt=>pt.Products)
                .HasForeignKey(p=>p.TypeId);

    }
}

public class BrandConfig : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.Property(b=>b.Name).IsRequired();
        builder.HasMany(b=>b.Products)
            .WithOne(p=>p.Brand)
            .HasForeignKey(p=>p.BrandId);
    }
}
public class ProductTypeConfig : IEntityTypeConfiguration<ProductType>
{
    public void Configure(EntityTypeBuilder<ProductType> builder)
    {
        builder.Property(b=>b.Name).IsRequired();
        builder.HasMany(b=>b.Products)
            .WithOne(p=>p.Type)
            .HasForeignKey(p=>p.TypeId);
    }
}