class Shape
{
    public void Area(int length, int breadth)
    {
        Console.WriteLine("The area of Rectangle is: " + length * breadth);
    }
    public void Area(double radius)
    {
        Console.WriteLine("The area of Circle is: "+ 3.14 * radius * radius);
    }
    public void Area(float baseheight, float height)
    {
        Console.WriteLine("The area of Triangle is: "+ 0.5 * baseheight * height);
    }
}

class Program
{
    public static void Main()
    {
        Shape shape = new Shape();

        shape.Area(2, 5);
        shape.Area(2.5);
        shape.Area(8.0f, 4.0f);
    }
}