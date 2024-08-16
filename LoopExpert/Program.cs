namespace LoopExpert;

class Program
{
    static void Main(string[] args)
    {
        // Call methods here to test
        Console.WriteLine(IsPassing(75)); // true
        Console.WriteLine(IsPassing(65)); // false

        Console.WriteLine(GetGradeClassification(95)); // A
        Console.WriteLine(GetGradeClassification(85)); // B
        Console.WriteLine(GetGradeClassification(65)); // C

        ViewItemsInListWithForEachLoop();
        ViewItemsInListWithForLoop();

        Console.WriteLine(IsEggsInList()); // true

        ViewMenuItems();
        Console.WriteLine(UserChoiceFromMenu());

        Console.WriteLine(CountIngredients()); // 6

        Console.WriteLine(IsItemInList("sugar")); // true
        Console.WriteLine(IsItemInList("salt")); // false

        PrintListInReverse();

        Console.WriteLine(HasEggsAndFlourAndButter()); // true
    }

    // 1. Complete the method to determine if a grade is passing.
    static bool IsPassing(int grade)
    {
        return grade >= 70;
    }
    
    // 2. Complete the method to return a grade classification as "A", "B", or "C" based on the grade.
    static string GetGradeClassification(int grade)
    {
        if (grade >= 90)
        {
            return "A";
        }
        else if (grade >= 70)
        {
            return "B";
        }
        else
        {
            return "C";
        }
    }

    // 3. Complete the method to print out all items in the list using a foreach loop.
    static void ViewItemsInListWithForEachLoop()
    {
        List<string> ingredientList = new List<string>() { "flour", "sugar", "eggs", "butter", "milk", "vanilla" };
        foreach (var item in ingredientList)
        {
            Console.WriteLine(item);
        }
    }

    // 4. Complete the method to print out all items in the list using a for loop.
    static void ViewItemsInListWithForLoop()
    {
        List<string> ingredientList = new List<string>() { "flour", "sugar", "eggs", "butter", "milk", "vanilla" };
        for (int i = 0; i < ingredientList.Count; i++)
        {
            Console.WriteLine(ingredientList[i]);
        }
    }

    // 5. Complete the method to check if "eggs" is in the list.
    static bool IsEggsInList()
    {
        List<string> ingredientList = new List<string>() { "flour", "sugar", "eggs", "butter", "milk", "vanilla" };
        for (int i = 0; i < ingredientList.Count; i++)
        {
            if (ingredientList[i] == "eggs")
            {
                return true;
            }
        }
        return false;
    }

    // 6. Create a method that displays a menu with three items.
    static void ViewMenuItems()
    {
        Console.WriteLine("1. Cheeseburger");
        Console.WriteLine("2. Caesar Salad");
        Console.WriteLine("3. Spaghetti Bolognese");
    }

    // 7. Complete the method to prompt the user to choose an item from the menu.
    static string UserChoiceFromMenu()
    {
        Console.WriteLine("Please choose an item from the menu (1-3): ");
        return Console.ReadLine();
    }

    // 8. Complete the method to count the number of ingredients in the list.
    static int CountIngredients()
    {
        List<string> ingredientList = new List<string>() { "flour", "sugar", "eggs", "butter", "milk", "vanilla" };
        return ingredientList.Count;
    }

    // 9. Complete the method to check if a specific item is in the list.
    static bool IsItemInList(string itemName)
    {
        List<string> ingredientList = new List<string>() { "flour", "sugar", "eggs", "butter", "milk", "vanilla" };
        for (int i = 0; i < ingredientList.Count; i++)
        {
            if (ingredientList[i] == itemName)
            {
                return true;
            }
        }
        return false;
    }

    // 10. Complete the method to print out all items in the list in reverse order.
    static void PrintListInReverse()
    {
        List<string> ingredientList = new List<string>() { "flour", "sugar", "eggs", "butter", "milk", "vanilla" };
        for (int i = ingredientList.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(ingredientList[i]);
        }
    }

    // 11. Complete the method to check if the list contains "eggs", "flour", and "butter".
    static bool HasEggsAndFlourAndButter()
    {
        List<string> ingredientList = new List<string>() { "flour", "sugar", "eggs", "butter", "milk", "vanilla" };
        bool hasEggs = false;
        bool hasFlour = false;
        bool hasButter = false;

        for (int i = 0; i < ingredientList.Count; i++)
        {
            if (ingredientList[i] == "eggs")
            {
                hasEggs = true;
            }
            if (ingredientList[i] == "flour")
            {
                hasFlour = true;
            }
            if (ingredientList[i] == "butter")
            {
                hasButter = true;
            }
        }

        return hasEggs && hasFlour && hasButter;
    }
}
