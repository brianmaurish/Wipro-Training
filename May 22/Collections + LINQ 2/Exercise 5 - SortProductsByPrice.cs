class Product
{
    public int Id;
    public string Name;
    public int Price;
}

class Program
{
    public static void Main(String[] args)
    {
        List<Product> products = new List<Product>();
        products.Add(new Product { Id = 1, Name = "Television", Price = 25000 });
        products.Add(new Product { Id = 2, Name = "Washing Machine", Price = 15000 });
        products.Add(new Product { Id = 3, Name = "Refrigerator", Price = 30000 });
        products.Add(new Product { Id = 4, Name = "Laptop", Price = 55000 });
        products.Add(new Product { Id = 5, Name = "Smartphone", Price = 20000 });
        products.Add(new Product { Id = 6, Name = "Air Conditioner", Price = 40000 });

        var sortedProducts = from p in products
                             orderby p.Price descending
                             select p;

        Console.WriteLine("Products sorted by price in Descending Order:");
        foreach (var product in sortedProducts)
        {
            Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
        }
    }
}

