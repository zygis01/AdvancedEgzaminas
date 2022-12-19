using AdvancedEgzaminas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedEgzaminas.Repositories
{
    public class FoodRepository
    {
        List<Food> foodMeniu = new();

        public FoodRepository()
        {
            try
            {
                foodMeniu.Add(new Food(0, "Nothing", 0.00));
                foodMeniu.Add(new Food(1, "Mac&Cheese", 4.99));
                foodMeniu.Add(new Food(2, "Baked onion rings", 7.99));
                foodMeniu.Add(new Food(3, "Medium cooked beef", 11.99));
                foodMeniu.Add(new Food(4, "Half raw eggs with bread", 5.99));
                foodMeniu.Add(new Food(5, "Gordon pizza", 15.99));
                foodMeniu.Add(new Food(6, "Chicken nuggets w fries", 9.99));
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error happened.. {ex.Message}");
            }
        }
        internal List<Food> GetFoodMeniu()
        {
            return foodMeniu;
        }
        public List<Food> ShowFoodMeniu()
        {
            foreach(Food food in GetFoodMeniu())
            {
                Console.WriteLine($"[{food.Id}] {food.Name} - {food.Price}");
            }
            return foodMeniu;
        }
        public Food GetFoodById(int foodId)
        {
            var tempRepository = foodMeniu[0];
            for (int i = 0; i < foodMeniu.Count; i++)
            {
                if (foodMeniu[i].Id == foodId)
                {
                    tempRepository = foodMeniu[i];
                }
            }
            return tempRepository;
        }
    }

}
