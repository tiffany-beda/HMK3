/* using System;

class Manticore
{
    private int health = 10;
    private int distance;

    public Manticore(int distance)
    {
        this.distance = distance;
    }

    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public int Distance
    {
        get { return distance; }
    }

    public override string ToString()
    {
        return $"Manticore: {health}/10";
    }
}

class City
{
    private int health = 15;

    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public override string ToString()
    {
        return $"City: {health}/15";
    }
}
/*

class Program
{
   static void Main()
    {
        City city = new City();
        Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
        Manticore manticore = new Manticore(GetValidNumber(0, 100));
        Console.Clear(); // Hide the distance from Player 2

        int roundNumber = 1;
        
        while (city.Health > 0 && manticore.Health > 0)
        {
            DisplayStatus(roundNumber, city, manticore);
            int damage = CalculateDamage(roundNumber);
            Console.WriteLine($"The cannon is expected to deal {damage} damage this round.\n");

            Console.Write("Enter desired cannon range: ");
            int guess = GetValidNumber(0, 100);

            if (guess < manticore.Distance)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("That round FELL SHORT of the target.");
            }
            else if (guess > manticore.Distance)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("That round OVERSHOT the target.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("That round was a DIRECT HIT!");
                manticore.Health -= damage;
            }
            Console.ResetColor();

            if (manticore.Health > 0)
            {
                city.Health--;
            }

            roundNumber++;
            Console.WriteLine("-----------------------------------------------------------");
        }

        if (manticore.Health <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The city of Consolas has been annihilated! The Manticore has won!");
        }
        Console.ResetColor();
    }

    static int GetValidNumber(int min, int max)
    {
        int number;
        while (!int.TryParse(Console.ReadLine(), out number) || number < min || number > max)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Please enter a valid number between {min} and {max}.");
            Console.ResetColor();
        }
        return number;
    }

    static void DisplayStatus(int round, City city, Manticore manticore)
    {
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine($"STATUS: Round: {round} {city} {manticore}");
    }

    static int CalculateDamage(int round)
    {
        if (round % 3 == 0 && round % 5 == 0)
            return 10;
        else if (round % 3 == 0 || round % 5 == 0)
            return 3;
        else
            return 1;
    }
}

*/