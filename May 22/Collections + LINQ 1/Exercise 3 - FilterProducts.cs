class Product
{
    public string Name;
    public int Price;
}

class Program
{
    public static void Main(String[] args)
    {
        List<Product> products = new List<Product>();
        products.Add(new Product { Name = "Television", Price = 25000 });
        products.Add(new Product { Name = "Washing machine", Price = 15000 });
        products.Add(new Product { Name = "Refrigerator", Price = 30000 });
        products.Add(new Product { Name = "Laptop", Price = 55000 });
        products.Add(new Product { Name = "Smartphone", Price = 200 });

        var a= from b in products
               where b.Price>500
               select b;

        Console.WriteLine("Products with price greater than 500: ");
        foreach(var c in a)
        {
            Console.WriteLine(c.Name);
        }
    }
}
