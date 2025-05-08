class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
}
class Program
{
    public static void Main(string[] args)
    {
        //Create product list with ID, Name and Price
        List<Product> products = new List<Product>
        {
            new Product { ID=101,Name="Laptop",Price=25000},
            new Product { ID=102,Name="Mouse",Price=250},
            new Product { ID=103,Name="Television",Price=45000},
            new Product { ID=104,Name="Keyboard",Price=1500},
            new Product { ID=105,Name="Speaker",Price=2500},
        };

        //Sort the products by price in descending order
        products.Sort((p1, p2) => p2.Price.CompareTo(p1.Price));
        foreach (var product in products)
        {
            Console.WriteLine($"ID: {product.ID}, Name:{product.Name}, Price:{product.Price}");
        }

        //Print the product with the highest price
        Console.WriteLine("The product with the highest price: ");
        Console.WriteLine($"ID: {products[0].ID}, Name:{products[0].Name}, Price:{products[0].Price}");
    }
}

