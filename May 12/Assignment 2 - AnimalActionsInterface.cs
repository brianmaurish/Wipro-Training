using System.Security.Cryptography.X509Certificates;

interface IAnimalActions
{
    void Eat();
    void Sleep();

}
class Lion : IAnimalActions
{
    public void Eat()
    {
        Console.WriteLine("Lion is eating meat");
    }
    public void Sleep()
    {
        Console.WriteLine("Lion is sleeping");
    }

}
class Elephant : IAnimalActions
{
    public void Eat()
    {
        Console.WriteLine("Elephant is eating grass");
    }
    public void Sleep()
    {
        Console.WriteLine("Elephant is sleeping");
    }

}

class Program
{
    public static void Main()
    {
        IAnimalActions animalActions;
        animalActions = new Lion();
        animalActions.Eat();
        animalActions.Sleep();

        animalActions = new Elephant();
        animalActions.Eat();
        animalActions.Sleep();
    }
}