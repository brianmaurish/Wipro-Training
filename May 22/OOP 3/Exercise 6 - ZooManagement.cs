abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public abstract void MakeSound();

    public void Feed()
    {
        Console.WriteLine("Feeding the animal...");
    }
}

class Lion : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Lion Roars!");
    }
}

class Elephant : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Elephant Prrrrs!");
    }
}

class Monkey : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Monkey screams!");
    }
}

class Zoo
{
    private List<Animal> animals = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public void InvokeAllActions()
    {
        foreach (var animal in animals)
        {
            animal.MakeSound();
            animal.Feed();
        }
    }
}

class Program
{
    static void Main()
    {
        Zoo zoo = new Zoo();

        zoo.AddAnimal(new Lion { Name = "Lion", Age = 5 });
        zoo.AddAnimal(new Elephant { Name = "Elephant", Age = 10 });
        zoo.AddAnimal(new Monkey { Name = "Monkey", Age = 3 });

        zoo.InvokeAllActions();
    }
}