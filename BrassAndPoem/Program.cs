
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
using System.ComponentModel.Design;

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
            Console.WriteLine(" ********** ALL PRODUCTS **********");
            DisplayAllProducts(products, productTypes);
            DisplayMenu();
            break;
        case "2":
            Console.Clear();
            Console.WriteLine(" ********** DELETE A PRODUCT **********");
            DeleteProduct(products, productTypes);
            DisplayMenu();
            break;
        case "3":
            Console.Clear();
            Console.WriteLine(" ********** ADD A PRODUCT ********** ");
            AddProduct(products, productTypes);
            DisplayMenu();
            break;
        case "4":
            Console.Clear();
            Console.WriteLine(" ********** UPDATE A PRODUCT ********** ");
            UpdateProduct(products, productTypes);
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
    Price: ${products[i].Price}
    Product Type: {productTypes.Where(p => p.Id == products[i].ProductTypeId).First().Title}");
    };
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    DisplayAllProducts(products, productTypes);
    Console.WriteLine("Which product would you like to delete?");
    Product delChoice = null;
    while (delChoice == null)
    {
        try
        {
            int response = Convert.ToInt32(Console.ReadLine());
            delChoice = products[response - 1];
        }
        catch (FormatException)
        {
            Console.WriteLine("Please type only integars.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Please only select an available product.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine("Follow the prompt.");
        }
    }
    Console.WriteLine($@"Are you sure you want to delete {delChoice.Name}
    1. Yes
    2. No");
    string finalAnswer = Console.ReadLine().Trim();
    switch (finalAnswer)
    {
        case "1":
            products.Remove(delChoice);
            Console.WriteLine("Product has been deleted.");
            break;
        case "2":
            Console.WriteLine("Nevermind.");
            break;
        default:
            Console.WriteLine("Invalid Entry");
            break;
    }
   
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("What is the name of the product you would like to add?");
    string createName = Console.ReadLine().Trim();

    Console.WriteLine("What is the price of this product?");
    decimal createPrice = 0.00M;
    while (createPrice == 0.00M)
    {
        try
        {
            createPrice = Convert.ToDecimal(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Only type integers.");
        }
    }
    

    Console.WriteLine("Which product type would you like to assign to this product? Enter the Id number.");
    foreach (ProductType productType in productTypes)
    {
        Console.WriteLine($"{productType.Id} - {productType.Title}");
    }

    int createPTId = 0;
    while (createPTId == 0)
    {
        try
        {
            createPTId = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Only type integers.");
        }

    }

    Product createProduct = new Product
    {
        Name = createName,
        Price = createPrice,
        ProductTypeId = createPTId
    };

    products.Add(createProduct);
    Console.WriteLine("Your product has been added!");

}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    DisplayAllProducts(products, productTypes);
    Console.WriteLine("Which product would you like to update?");
    Product choice = null;
    while (choice == null)
    {
        try
        {
            int response = Convert.ToInt32(Console.ReadLine());
            choice = products[response - 1];
        }
        catch (FormatException)
        {
            Console.WriteLine("Please only type integars.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Please only choose a number associated with an existing item.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine("Invalid entry. Try again.");
        }
    }
    Console.WriteLine($@"Which would you like to edit?
    1. Name: {choice.Name}
    2. Price: {choice.Price}
    3. Product Type Id: {choice.ProductTypeId} - {productTypes.Where(p => p.Id == choice.ProductTypeId).First().Title}");

    string answer = Console.ReadLine().Trim();

    switch (answer)
    {
        case "1":
            Console.WriteLine("What is the updated name of this product?");
            string updateName = Console.ReadLine().Trim();
            choice.Name = updateName;
            Console.WriteLine("Your product name has been updated!");
            break;
        case "2":
            Console.WriteLine("What is the new price of the product?");
            decimal updatePrice = Convert.ToDecimal(Console.ReadLine());
            choice.Price = updatePrice;
            Console.WriteLine("Your product price has been updated!");
            break;
        case "3":
            Console.WriteLine("Please choose the updated Product Type Id:");
            for (int i = 0; i < productTypes.Count; i++)
            {
                Console.WriteLine(@$"   {i + 1}. {productTypes[i].Title}");
            }
            int updateId = Convert.ToInt32(Console.ReadLine());
            choice.ProductTypeId = updateId;
            Console.WriteLine("Your product type Id has been updated!");
            break;
        default:
            Console.WriteLine("Invalid Entry.");
            break;
    }

}


// don't move or change this!
public partial class Program { }