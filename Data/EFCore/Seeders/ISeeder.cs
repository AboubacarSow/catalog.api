using catalog.api.Data.Entities;

namespace catalog.api.Data.EFCore.Seeders;

public interface ISeeder
{
    public Task SeedAsync();
}

public class Seeder(CatalogContext context) : ISeeder
{
    public async Task SeedAsync()
    {
        if (!context.Brands.Any())
            await context.Brands.AddRangeAsync(GetBrands());
        if(!context.ProductTypes.Any())
            await context.ProductTypes.AddRangeAsync(GetProductTypes());
        if (!context.Products.Any())
            await context.Products.AddRangeAsync(GetProducts());

        await context.SaveChangesAsync();
    }

    private static ProductType[] GetProductTypes()
    {
        return
            [
                new ProductType(1, "Laptop"),
                new ProductType(2, "Smartphone"),
                new ProductType(3, "Tablet")
            ];
    }

    private static Product[] GetProducts()
    {
        return
        [
            new Product(
                Id: 1,
                Name: "MacBook Pro 14",
                Price: 2499.99m,
                Description: "Apple M3 Pro laptop"
            )
            {
                BrandId = 1,
                TypeId = 1,
                AvailableStock = 15,
                ImageFileName = "macbook-pro-14.png",
                OnReorder = false,
                RestockThreshold = 5
            },

            new Product(
                Id: 2,
                Name: "iPhone 15 Pro",
                Price: 1199.99m,
                Description: "Apple flagship smartphone"
            )
            {
                BrandId = 1,
                TypeId = 2,
                AvailableStock = 30,
                ImageFileName = "iphone-15-pro.png",
                OnReorder = false,
                RestockThreshold = 10
            },

            new Product(
                Id: 3,
                Name: "Galaxy S24",
                Price: 1099.99m,
                Description: "Samsung premium Android phone"
            )
            {
                BrandId = 2,
                TypeId = 2,
                AvailableStock = 25,
                ImageFileName = "galaxy-s24.png",
                OnReorder = false,
                RestockThreshold = 8
            },

            new Product(
                Id: 4,
                Name: "Dell XPS 13",
                Price: 1799.99m,
                Description: "Ultra-portable Windows laptop"
            )
            {
                BrandId = 3,
                TypeId = 1,
                AvailableStock = 10,
                ImageFileName = "dell-xps-13.png",
                OnReorder = true,
                RestockThreshold = 5
            }
        ];
    }

    private static Brand[] GetBrands()
    {
         return
            [
                new Brand(1, "Apple"),
                new Brand(2, "Samsung"),
                new Brand(3, "Dell")
            ];
    }

   
}