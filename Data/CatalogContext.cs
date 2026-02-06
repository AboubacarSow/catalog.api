using catalog.api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace catalog.api.Data;

public class CatalogContext(DbContextOptions<CatalogContext> options) : DbContext(options)
{
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Brand> Brands => Set<Brand>();

}