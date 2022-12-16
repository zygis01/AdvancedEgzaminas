using AdvancedEgzaminas.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedEgzaminas.Models
{
    public class Restaurant
    {
        public const string restaurantName = "(-_(-_-)_-) EuropeanYard (-_(-_-)_-)";
        public string name => restaurantName;

        public List<Table> tables = new List<Table>()
        {
            new Table(1, 4, false),
            new Table(2, 4, true),
            new Table(3, 4, true),
            new Table(4, 4, false),
            new Table(5, 4, true),
        };
    }
}
