namespace catalog.api.Data.Entities;

public record Brand(int Id,string Name)
{
    public ICollection<Product> Products{get;set;} = default!;
}
