using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedEgzaminas.Models
{
    public class Restoranas
    {
        public const string restoranoPavadinimas = "GarduGardu";
        public string name => restoranoPavadinimas;

        public List<Staliukas> staliukai = new List<Staliukas>()
        {
            new Staliukas(1, 4),
            new Staliukas(2, 6),
            new Staliukas(3, 5),
            new Staliukas(4, 2),
            new Staliukas(5, 2),
            new Staliukas(6, 1),
            new Staliukas(7, 3)
        };


    }
}
