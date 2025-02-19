using System;

// Enumeration for arrowhead types
enum Arrowhead { Steel, Wood, Obsidian }

// Enumeration for fletching types
enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }

class Arrow
{
    // Private fields
    private Arrowhead arrowhead;
    private Fletching fletching;
    private float length;

    // Constructor
    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
    {
        this.arrowhead = arrowhead;
        this.fletching = fletching;
        Length = length; // Use property to validate length
    }

    // Properties
    public Arrowhead ArrowheadType
    {
        get { return arrowhead; }
    }

    public Fletching FletchingType
    {
        get { return fletching; }
    }

    public float Length
    {
        get { return length; }
        private set 
        {
            if (value < 60 || value > 100)
                throw new ArgumentException("Length must be between 60 and 100 cm.");
            length = value;
        }
    }

    // Method to calculate cost
    public float GetCost()
    {
        float arrowheadCost = arrowhead switch
        {
            Arrowhead.Steel => 10f,
            Arrowhead.Wood => 3f,
            Arrowhead.Obsidian => 5f,
            _ => 0f
        };

        float fletchingCost = fletching switch
        {
            Fletching.Plastic => 10f,
            Fletching.TurkeyFeathers => 5f,
            Fletching.GooseFeathers => 3f,
            _ => 0f
        };

        float shaftCost = length * 0.05f;
        return arrowheadCost + fletchingCost + shaftCost;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose an arrowhead: Steel, Wood, Obsidian");
        Arrowhead arrowhead = (Arrowhead)Enum.Parse(typeof(Arrowhead), Console.ReadLine(), true);

        Console.WriteLine("Choose a fletching: Plastic, TurkeyFeathers, GooseFeathers");
        Fletching fletching = (Fletching)Enum.Parse(typeof(Fletching), Console.ReadLine(), true);

        Console.WriteLine("Enter the shaft length (60-100 cm):");
        float length = float.Parse(Console.ReadLine());

        try
        {
            Arrow arrow = new Arrow(arrowhead, fletching, length);
            Console.WriteLine($"The arrow costs {arrow.GetCost()} gold.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}
