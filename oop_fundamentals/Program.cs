// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Linq.Expressions;

var animal = new Animal("Animal name", 5);
animal.MakeSound();

var pitbull = new Dog("Pancho", 3, "Pitbull");
pitbull.MakeSound();


// Example # 2 **
var product1 = new Product(1, "Erdinger", 10);
var product2 = new Product(2, "Delirium", 8);
var product3 = new Product(3, "Paulanear", 7);

var customer = new Customer(1, "Dwaxgio");

var sale = new Sale(1, customer);
sale.AddConcept(product1, 2);
sale.AddConcept(product3, 1);

Console.WriteLine(sale.Total);

// Example # 2 **

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

// Example # 2 **
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(int id, string name, int price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Customer(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

public class Concept
{
    public Product Product { get; set; }
    public int Quantity { get; set; }

    // Behavior
    public decimal Subtotal
    {
        get { return Product.Price * Quantity; }
    }

    public Concept(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }
}

public class Sale
{
    public int Id { get; set; }
    public Customer Customer { get; set; }
    public List<Concept> Concepts { get; set; }
    public DateTime Date { get; set; }

    public decimal Total
    {
        get
        {
            decimal total = 0;
            foreach(var concept in Concepts)
            {
                total += concept.Subtotal;
            }
            return total;
        }
    }

    // Constructor
    public Sale(int id, Customer customer)
    {
        Id = id;
        Customer = customer;
        // Initialize object Concepts
        Concepts = new List<Concept>();
        Date = DateTime.Now;
    }

    // Behavior
    public void AddConcept(Product product, int quantity)
    {
        Concepts.Add(new Concept(product, quantity));
    }
}
// Example # 2 **




