using System;

class Program
{
    static void Main()
    {
        // Create an instance of Octopus
        Octopus o = new Octopus("Jack");
       
        // Display the Octopus details
        Console.WriteLine($"Octopus Name: {o.Name}");
        Console.WriteLine($"Octopus Age: {o.Age}");
        Console.WriteLine($"Octopus Legs: {o.Legs}");
        Console.WriteLine($"Octopus Eyes: {o.Eyes}");
       
        // Create an instance of BorderSides enum with flags
        BorderSides sides = BorderSides.Left | BorderSides.Right;
        Console.WriteLine($"Bordersides: {sides}");

        // Check if the flag includes Left
        if ((sides & BorderSides.Left) != 0)
        {
            Console.WriteLine("Includes Left");
        }
    }
}

class Octopus
{
    // Instance fields
    private string name;
    public readonly int Legs = 8;      // Readonly field for legs (immutable)
    public readonly int Eyes = 2;      // Readonly field for eyes (immutable)
    public int Age { get; set; } = 10; // Public field with default value of 10

    // Constructor to initialize name
    public Octopus(string name)
    {
        this.name = name;
    }

    // Property to get the name
    public string Name
    {
        get { return name; }
    }
}

[Flags]
public enum BorderSides
{
    None = 0,
    Left = 1,
    Right = 2,
    Top = 4,
    Bottom = 8,
    LeftRight = Left | Right,
    TopBottom = Top | Bottom,
    All = LeftRight | TopBottom
}