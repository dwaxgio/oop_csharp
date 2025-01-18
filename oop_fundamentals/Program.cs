// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var animal = new Animal("Animal name", 5);
animal.MakeSound();

var pitbull = new Dog("Pancho", 3, "Pitbull");
pitbull.MakeSound();

Console.ReadLine();

// Mold
public class Animal
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Functions
    public virtual void MakeSound()
    {
        Console.WriteLine("Makes a sound");
    }
}

// Inheritance
public class Dog : Animal
{
    public string Race { get; set; }

    public Dog(string name, int age, string race) : base(name, age)
    {
        Race = race;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Barks");
    }
}


