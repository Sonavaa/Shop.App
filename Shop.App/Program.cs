using Shop.Core.Models;
using System.Text.RegularExpressions;

Product[] products = new Product[0];
Console.WriteLine("1.Create product");
Console.WriteLine("2.Show products");
Console.WriteLine("0.close");
string Request = Console.ReadLine();
while (Request != "0")
{
    switch (Request)
    {
        case "1":
            Create();
            break;
        case "2":
            ShowProducts();
            break;
        default:
            Console.WriteLine("please add valid option");
            break;
    }
    Request = Console.ReadLine();
}

void Create()
{
    Console.WriteLine("Name daxil edin");
    string Name = ValidateProducts(Console.ReadLine());
    Console.WriteLine("Price daxil edin");
    double Price = double.Parse(ValidateProducts(Console.ReadLine()));
    Console.WriteLine("Category daxil edin");
    string Category = ValidateProducts(Console.ReadLine());
    Console.WriteLine("StockCount daxil edin");
    int StockCount = int.Parse(ValidateProducts(Console.ReadLine()));

    Product product = new Product(Name, Price, Category, StockCount);
    Array.Resize(ref products, products.Length+1);
   products[products.Length - 1] = product;
}
Create();
void ShowProducts()
{
    foreach (Product product in products)
    {
        Console.WriteLine(product.GetFullInfo());
    }
}
string ValidateProducts(string data)
{   
    while (string.IsNullOrWhiteSpace(data))
    {
        Console.WriteLine("Pleasa add valid value");
        data = Console.ReadLine();
    }
    return data;
}
ShowProducts();