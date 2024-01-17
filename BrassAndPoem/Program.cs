
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "French Horn", 
        Price = 500.0M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Devotions by Mary Oliver",
        Price = 30.0M,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "The Orange and Other Poems by Wendy Cope",
        Price = 25.0M,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "Trombone",
        Price = 1000.0M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Tuba",
        Price = 740.0M,
        ProductTypeId = 1
    }
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType()
    {
        Title = "Instrument",
        Id = 1,
    },
    new ProductType()
    {
        Title = "Poetry",
        Id = 2,
    }
};
//put your greeting here

//implement your loop here

void DisplayMenu()
{
    throw new NotImplementedException();
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }