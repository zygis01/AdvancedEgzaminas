using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedEgzaminas.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Food(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
