using AdvancedEgzaminas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedEgzaminas.Repositories
{
    public class DrinksRepository
    {
        List<Drink> drinksMeniu = new();

        public DrinksRepository()
        {
            drinksMeniu.Add(new Drink(1, "Coca Cola", 2.99));
            drinksMeniu.Add(new Drink(2, "Fanta", 1.99));
            drinksMeniu.Add(new Drink(3, "Sprite", 1.99));
            drinksMeniu.Add(new Drink(4, "Redbull", 3.99));
        }
        internal List<Drink> GetDrinksMeniu()
        {
            return drinksMeniu;
        }
        public List<Drink> ShowDrinksMeniu()
        {
            foreach (Drink drink in GetDrinksMeniu())
            {
                Console.WriteLine($"[{drink.Id}] {drink.Name} - {drink.Price}");
            }
            return drinksMeniu;
        }
        public Drink GetDrinkById(int drinkId)
        {
            var tempRepository = drinksMeniu[0];
            for (int i = 0; i < drinksMeniu.Count; i++)
            {
                if (drinksMeniu[i].Id == drinkId)
                {
                    tempRepository = drinksMeniu[i];
                }
            }
            return tempRepository;
        }
    }
}
