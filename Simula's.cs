using System;

// Define enumerations for recipe type, main ingredient, and seasoning
enum RecipeType { Soup, Stew, Gumbo }
enum MainIngredient { Mushrooms, Chicken, Carrots, Potatoes }
enum Seasoning { Spicy, Salty, Sweet }

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Simula's Soup Kitchen!");

        // Get user choices
        RecipeType recipe = GetChoice<RecipeType>("Choose a recipe (Soup, Stew, Gumbo): ");
        MainIngredient ingredient = GetChoice<MainIngredient>("Choose a main ingredient (Mushrooms, Chicken, Carrots, Potatoes): ");
        Seasoning seasoning = GetChoice<Seasoning>("Choose a seasoning (Spicy, Salty, Sweet): ");

        // Store selections in a tuple
        var soup = (recipe, ingredient, seasoning);

        // Display the final selection
        Console.WriteLine($"You made: {soup.seasoning} {soup.ingredient} {soup.recipe}!");
    }

    static T GetChoice<T>(string prompt) where T : struct, Enum
    {
        while (true)
        {
            Console.Write(prompt);
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string input = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            if (Enum.TryParse(input, true, out T choice))
            {
                return choice;
            }
            Console.WriteLine("Invalid choice, please try again.");
        }
    }
}
