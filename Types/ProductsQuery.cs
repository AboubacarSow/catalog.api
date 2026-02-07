using catalog.api.Data;
using catalog.api.Data.Entities;
using GreenDonut.Data;
using Microsoft.EntityFrameworkCore;

namespace catalog.api.Types;

[QueryType]
public static class ProductsQuery
{
    public static async Task<Product?> GetProductByIdAsync(int id,
           //With query context no need for sorting, and sql command becomes more simpler
         [Service]CatalogContext context, 
                CancellationToken cancellationToken)
    => await context.Products
                    .FirstOrDefaultAsync(p=>p.Id == id,cancellationToken);

    public static async Task<List<Product>> GetAllProducts(
   [Service] CatalogContext context,
    CancellationToken cancellationToken) 
    => await context.Products.OrderBy(p=>p.Name)
                            .ToListAsync(cancellationToken);
}
