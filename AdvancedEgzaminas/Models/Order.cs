using AdvancedEgzaminas.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedEgzaminas.Models
{
    public class Order
    {
        public int TransactionNum { get; set; }
        public string CustomerName { get; set; }
        public int CustomerTableId { get; set; }
        public Food food { get; set; }
        public Drink drink { get; set; }
        public DateTime dateAndTime { get; set; }
        public Order(DateTime DateAndTime, Food Food, Drink Drink, string customerName, int customerTableId)
        {
            dateAndTime = DateAndTime;
            food = Food;
            drink = Drink;
            CustomerName = customerName;
            CustomerTableId = customerTableId;
            
        }
       
    }
}
