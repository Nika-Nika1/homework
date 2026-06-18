namespace homework_8;

public class Product
{
    public int Id {get; set;}
    public string Name {get; set;}
    public double Price {get; set;}
    public bool Nuts {get; set;}
    public string image {get; set;}
    public bool Vegetarian {get; set;}
    public double Spiciness {get; set;}
    public string Category {get; set;}

    public void ProductInfo()
    {
        Console.WriteLine($"This is Product called {Name},it's price is {Price},spiciness {Spiciness}.");

        Console.WriteLine(Vegetarian == false ? $"{Name} isn't vegetarian." : $"{Name} is vegetarian.");
        Console.WriteLine(Nuts == false ? $"{Name} doesn't contains nuts." : $"{Name}  contains nuts.");

        Console.WriteLine($"This product is in {Category} category,You can check it");
    }
}