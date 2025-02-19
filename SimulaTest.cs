using System;

// Define an enumeration for the state of the chest
enum ChestState { Locked, Unlocked, Open }

class Programs
{
    static void Main()
    {
        ChestState chest = ChestState.Locked;
        
        while (true)
        {
            Console.WriteLine($"The chest is {chest}. What do you want to do?");
            string command = Console.ReadLine()?.ToLower();

            switch (command)
            {
                case "unlock":
                    if (chest == ChestState.Locked)
                        chest = ChestState.Unlocked;
                    else
                        Console.WriteLine("You can't unlock an already unlocked or open chest.");
                    break;
                
                case "lock":
                    if (chest == ChestState.Unlocked)
                        chest = ChestState.Locked;
                    else
                        Console.WriteLine("You can't lock an open or already locked chest.");
                    break;
                
                case "open":
                    if (chest == ChestState.Unlocked)
                        chest = ChestState.Open;
                    else
                        Console.WriteLine("You can't open a locked chest.");
                    break;
                
                case "close":
                    if (chest == ChestState.Open)
                        chest = ChestState.Unlocked;
                    else
                        Console.WriteLine("You can't close an already closed chest.");
                    break;
                
                default:
                    Console.WriteLine("Invalid command. Try 'unlock', 'lock', 'open', or 'close'.");
                    break;
            }
        }
    }
}
