
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "French Horn", 
        Price = 500.00M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Devotions by Mary Oliver",
        Price = 30.00M,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "The Orange and Other Poems by Wendy Cope",
        Price = 25.00M,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "Trombone",
        Price = 1000.00M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Tuba",
        Price = 740.00M,
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
string greeting = @"    ********** WELCOME TO BRASS & POEM ********** 
Your one stop shop for poetry and all things brass.";
Console.WriteLine(greeting);
DisplayMenu();

//implement your loop here
string choice = null;
while (choice != "5")
{
    choice = Console.ReadLine().Trim();

    switch (choice)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Display all Products");
            DisplayAllProducts(products, productTypes);
            DisplayMenu();
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Delete a Product");
            // Delete a Product
            DisplayMenu();
            break;
        case "3":
            Console.Clear();
            Console.WriteLine("Add a product");
            // Add a product
            DisplayMenu();
            break;
        case "4":
            Console.Clear();
            Console.WriteLine("Update a Product");
            // Update a product
            DisplayMenu();
            break;
        case "5":
            Console.WriteLine("Goodbye");
            break;
        default:
            Console.WriteLine("Invalid Entry. Please try again.");
            break;
    }
}

void DisplayMenu()
{
    string options = @"
Choose an option to continue:
    1. Display all Products
    2. Delete a Product
    3. Add a Product
    4. Update a Product
    5. Exit
    ";
    Console.WriteLine(options);
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    
    for (int i = 0 ; i < products.Count; i++)
    {
        Console.WriteLine(@$"{i + 1}. {products[i].Name}
    Price: {products[i].Price}
    Product Type: {productTypes.Where(p => p.Id == products[i].ProductTypeId).First().Title}");
    };
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