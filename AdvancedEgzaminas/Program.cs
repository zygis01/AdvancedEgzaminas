using AdvancedEgzaminas.Models;
using AdvancedEgzaminas.Repositories;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

Restaurant restaurant = new();
Waitress waitress = new();
FoodRepository foodRepo = new();
DrinksRepository drinksRepo = new();
restaurant.FillTxtWithList();

bool startProgram = true;

while (startProgram)
{
    Console.WriteLine(Restaurant.restaurantName);

    Console.WriteLine("Welcome, how many people came: ?");
    int peopleCount;
    bool isSuccessPeopleCount = int.TryParse(Console.ReadLine(), out peopleCount);

    int readTableId;
    if (peopleCount >= 1 && peopleCount <= 4 && isSuccessPeopleCount == true)
    {
        Console.WriteLine("Those are all of the tables that we have!");
        Console.WriteLine();
        waitress.ShowAllTables(startProgram);

        Console.WriteLine("Select the table you would like to take: ");
        bool isSuccessReadTableId = int.TryParse(Console.ReadLine(), out readTableId);
        Console.Clear();

        if (isSuccessReadTableId == true)
        {
            var table = restaurant.tables.Find(x => x.id == readTableId);
            if (table.isEmpty == false)
            {
                Console.WriteLine("This table is already reserved.. Sorry!");
                return;
            }
            else
            {
                waitress.ReserveTable(readTableId, startProgram);
            }
        }
        else
        {
            Console.WriteLine("Wrong number.. try again!");
            return;
        }
        Console.WriteLine("What would you like to order from food meniu? [x]!");
        Console.WriteLine();
        foodRepo.ShowFoodMeniu();

        int foodOption;
        bool isSuccessFoodOption = int.TryParse(Console.ReadLine(), out foodOption);
        if (foodOption > 6 && isSuccessFoodOption == false)
        {
            Console.WriteLine("Wrong choice.. try again!");
        }
        if (foodOption == 0)
        {
            Console.WriteLine("You didnt choose any dish..");
        }

        Console.WriteLine("What would you like to order from drinks meniu? [x]!");
        Console.WriteLine();
        drinksRepo.ShowDrinksMeniu();

        int drinkOption;
        bool isSuccessDrinkOption = int.TryParse(Console.ReadLine(), out drinkOption);
        if (drinkOption > 4 && drinkOption < 1 && isSuccessDrinkOption == false)
        {
            Console.WriteLine("Wrong choice.. try again!");
            
        }
        Console.WriteLine("Whats your name Mr/Mis? ");
        string readName = Console.ReadLine();

        try
        {
            var chosenFood = foodRepo.GetFoodById(foodOption);
            var chosenDrink = drinksRepo.GetDrinkById(drinkOption);

            waitress.RegisterOrder(readName, readTableId, chosenFood, chosenDrink);
            waitress.PrintReceipt(chosenDrink, chosenFood);
            waitress.SendReceiptToEmail(readTableId);
            return;
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Something went wrong.. {ex.Message}");
        }
    }
    else if (peopleCount < 1 || peopleCount > 4)
    {
        Console.WriteLine("Sorry, we dont have seats for that many people..");
        startProgram = false;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Wrong input.. try again!");
    }
}



