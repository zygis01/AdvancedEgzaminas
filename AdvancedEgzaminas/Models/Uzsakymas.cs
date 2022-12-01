using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedEgzaminas.Models
{
    public class Uzsakymas
    {
        public int uzsakymoId { get; set; }
        public DateTime dataIrLaikas { get; set; }
        public Uzsakymas(int UzsakymoId, DateTime DataIrLaikas)
        {
            uzsakymoId = UzsakymoId;
            dataIrLaikas = DataIrLaikas;
        }

    }
}
