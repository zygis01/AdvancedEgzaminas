using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedEgzaminas.Models
{
    public class Table
    {
        public int id { get; set; }
        public int emptySeats { get; set; }
        public bool isEmpty { get; set; }
        public Table(int Id, int EmptySeats, bool IsEmpty)
        {
            id = Id;
            emptySeats = EmptySeats;
            isEmpty = IsEmpty;
        }
    }
}
