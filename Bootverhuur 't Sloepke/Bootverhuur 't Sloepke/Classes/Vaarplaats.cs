using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bootverhuur__t_Sloepke.Database;

namespace Bootverhuur__t_Sloepke.Classes
{
    class Vaarplaats
    {
        private VaarplaatsDatabase _db = new VaarplaatsDatabase();

        public string Naam { get; set; }
        
        public decimal Prijs { get; set; }

        public Vaarplaats()
        {
            
        }

        public bool AddVaarplaats(Vaarplaats vaar)
        {
            return _db.AddVaarplaats(vaar);
        }
    }
}
