using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bootverhuur__t_Sloepke.Database;

namespace Bootverhuur__t_Sloepke.Classes
{
    class Materiaal : iProduct
    {
        private MateriaalDatabase _db = new MateriaalDatabase();

        public string Naam { get; set; }

        public decimal Prijs { get; set; }

        public int ID { get; set; }

        public Materiaal()
        {
            
        }

        public bool AddMateriaal(Materiaal materiaal)
        {
            return _db.AddMateriaal(materiaal);
        }
    }
}
