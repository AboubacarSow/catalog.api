using catalog.api.Data;
using catalog.api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace catalog.api.Types;

[QueryType]
public static class BrandsQuery
{
    public static async Task<Brand?> GetBrandByIdAsync(int id, CatalogContext context, CancellationToken cancellationToken)=>
        await context.Brands.FirstOrDefaultAsync(b=>b.Id==id,cancellationToken);
}