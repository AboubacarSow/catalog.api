namespace catalog.api.Data.Entities;

public record Product(int Id,
        string Name,
        decimal Price,
        string Description
        )
{
    public int BrandId {get;set;} = default!;
    public Brand Brand { get;set;} = default!;
    public int AvailableStock { get; set;} = default!;
    public string ImageFileName{ get;set;} = default!;
    public bool OnReorder { get;set;} = default!;
    public int RestockThreshold{ get;set;} = default!;
    public int TypeId{get;set;}
    public ProductType Type{get;set;} = default!;
 
}


