using System.Security.Cryptography.X509Certificates;

abstract class Animal
{
    public abstract void MakeSound();
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }

}
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Barks");
    }
}
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meows");
    }
}

class Program
{
    public static void Main()
    {
        Animal dog = new Dog();
        dog.MakeSound();
        dog.Eat();

        Animal cat = new Cat();
        cat.MakeSound();
        cat.Eat();


    }
}