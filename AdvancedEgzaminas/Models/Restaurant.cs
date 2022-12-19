using AdvancedEgzaminas.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedEgzaminas.Models
{
    public class Restaurant
    {
        public string drinkPath = "C:\\Users\\Zygimantas\\source\\repos\\AdvancedEgzaminas\\AdvancedEgzaminas\\TxtData\\Drinks.txt";
        public string foodPath = "C:\\Users\\Zygimantas\\source\\repos\\AdvancedEgzaminas\\AdvancedEgzaminas\\TxtData\\Food.txt";
        public const string restaurantName = "(-_(-_-)_-) EuropeanYard (-_(-_-)_-)";
        public string name => restaurantName;
        DrinksRepository drinkRepo = new();
        FoodRepository foodRepo = new();

        public List<Table> tables = new List<Table>()
        {
            new Table(1, 4, false),
            new Table(2, 4, true),
            new Table(3, 4, true),
            new Table(4, 4, false),
            new Table(5, 4, true),
        };
        public void FillTxtWithList()
        {
            if (File.Exists(drinkPath) && File.Exists(foodPath))
            {
                foreach (Drink drink in drinkRepo.GetDrinksMeniu())
                {
                    if (File.ReadLines(drinkPath).Any(line => line.Contains(drink.Name)))
                    {
                        break;
                    }
                    else
                    {
                        File.AppendAllText(drinkPath, $"{drink.Id} - {drink.Name} || {drink.Price}\n");
                    }
                }
                foreach (Food food in foodRepo.GetFoodMeniu())
                {
                    if (File.ReadAllLines(foodPath).Any(line => line.Contains(food.Name)))
                    {
                        break;
                    }
                    else
                    {
                        File.AppendAllText(foodPath, $"{food.Id} - {food.Name} || {food.Price}\n");
                    }
                }
            }
        }
    }
}
