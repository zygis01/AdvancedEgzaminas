using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedEgzaminas.Models
{
    public class Staliukas
    {
        public int numeris { get; set; }
        public int sedimuVietuSkaicius { get; set; }
        public Staliukas(int Numeris, int SedimuVietuSkaicius)
        {
            numeris = Numeris;
            sedimuVietuSkaicius = SedimuVietuSkaicius;
        }
    }
}
