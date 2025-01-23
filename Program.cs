
using Microsoft.VisualBasic.FileIO;
using Mission3FoodBank;

// initializing variables
List<FoodItem> foods = new List<FoodItem>();
string input = ""; 
int choice = 0;
bool loop = false;
string name = "";
string category = "";
string quantityString = "";
int quantity = 0;
string expiration = "";
string delete = "";
int deleteNum = 0;

do
{
    bool isValid = false;
    while (!isValid)
    {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1: Add Food Item(s)");
        Console.WriteLine("2: Delete Food Item(s)");
        Console.WriteLine("3: Print List of Current Food Item(s)");
        Console.WriteLine("4: Exit the Program");
        input = Console.ReadLine();

        // making sure user enters a number 1-4
        if (int.TryParse(input, out choice))
        {
            if (choice >= 1 && choice <= 4)
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Enter a valid number.");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Invalid input. Enter a valid number.");
            Console.WriteLine();
        }
    }

    // adding food items
    if (choice == 1)
    {
        // collecting food info
        Console.WriteLine();
        Console.WriteLine("Enter the name of the food: ");
        name = Console.ReadLine();
        Console.WriteLine("Enter the food category: ");
        category = Console.ReadLine();

        // making sure the quantity is a positive number
        isValid = false;
        while (!isValid)
        {
            Console.WriteLine("Enter the quantity: ");
            quantityString = Console.ReadLine();

            // making sure user enters a positive quantity
            if (int.TryParse(quantityString, out quantity))
            {
                if (quantity > 0)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter a valid number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Enter a valid number.");
            }
        }

        Console.WriteLine("Enter the expiration date: ");
        expiration = Console.ReadLine();
        // creating a new FoodItem object and adding it to the foods list
        foods.Add(new FoodItem(name, category, quantity, expiration));
        Console.WriteLine();
        choice = 0;
    }

    // deleting food items
    else if (choice == 2)
    {
        isValid = false;
        while (!isValid)
        {
            Console.WriteLine();
            // listing available foods
            Console.WriteLine("Which food do you want to delete?");
            for (int i = 0; i < foods.Count; i++)
            {
                Console.WriteLine((i + 1) + ": " + foods[i].Name);
            }

            delete = Console.ReadLine();

            // making sure that the user enters a number in the list of foods
            if (int.TryParse(delete, out deleteNum) && deleteNum > 0 && deleteNum <= foods.Count)
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Enter a valid number");
            }
        }
                
        foods.RemoveAt(deleteNum - 1);
        Console.WriteLine("Food successfully removed.");
        Console.WriteLine();
        choice = 0;
    }

    // print list of current food items
    else if (choice == 3)
    {
        Console.WriteLine();
        for (int i = 0; i < foods.Count; i++)
        {
            Console.WriteLine(foods[i].Name);
        }
        Console.WriteLine();
        choice = 0;
    }

    // exiting the program
    else if (choice == 4)
    {
        loop = true;
    }
}
while (!loop);