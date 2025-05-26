class Item
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Stock { get; set; }
    public int Price { get; set; } // Price is in cents (e.g., 99999 represents $999.99)
}
class Program
{
    static void Main(string[] args)
    {
        List<Item> items = new List<Item>
        {
            new Item { Name = "Laptop", Type = "Electronics", Stock = 50, Price = 99999 },
            new Item { Name = "Phone", Type = "Electronics", Stock = 200, Price = 49949 },
            new Item { Name = "Shirt", Type = "Clothing", Stock = 150, Price = 2999 },
            new Item { Name = "Pants", Type = "Clothing", Stock = 120, Price = 4999 },
            new Item { Name = "Headphones", Type = "Electronics", Stock = 75, Price = 7999 },
            new Item { Name = "Shoes", Type = "Footwear", Stock = 180, Price = 6999 },
            new Item { Name = "Smartwatch", Type = "Electronics", Stock = 65, Price = 19999 },
            new Item { Name = "T-shirt", Type = "Clothing", Stock = 50, Price = 1999 },
            new Item { Name = "Refrigerator", Type = "Appliance", Stock = 30, Price = 59999 },
            new Item { Name = "Washing Machine", Type = "Appliance", Stock = 40, Price = 39999 },
            new Item { Name = "Toaster", Type = "Appliance", Stock = 25, Price = 2999 },
            new Item { Name = "Coffee Maker", Type = "Appliance", Stock = 45, Price = 4999 },
            new Item { Name = "Backpack", Type = "Accessories", Stock = 100, Price = 3999 },
            new Item { Name = "Sunglasses", Type = "Accessories", Stock = 80, Price = 5999 },
            new Item { Name = "Desk Chair", Type = "Furniture", Stock = 60, Price = 12999 }
        };

        var lowStockItems = from item in items
                            where item.Stock < 60
                            select item;

        var grouped = from item in lowStockItems
                      group item by item.Type into g
                      select g;

        var highestPricedItems = from a in grouped
                                 select new
                                 {
                                     Type = a.Key,
                                     HighestPricedItem = a.OrderByDescending(item => item.Price).FirstOrDefault()
                                 };

        Console.WriteLine("\nHighest Priced Item in Each Group:");
        foreach (var group in highestPricedItems)
        {
            Console.WriteLine($"Type: {group.Type}");
            var item = group.HighestPricedItem;
            if (item != null)
            {
                Console.WriteLine($"  Highest Priced Item: {item.Name}, Price: {item.Price}");
            }
            else
            {
                Console.WriteLine("  No items available in this group.");
            }
        }
    }
}
