namespace catalog.api.Data.Entities;

public record ProductType(int Id,string Name)
{
    public ICollection<Product> Products {get;set;}= default!;
}