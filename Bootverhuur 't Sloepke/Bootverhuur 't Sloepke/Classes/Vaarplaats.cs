using System.Collections.Generic;
using Bootverhuur__t_Sloepke.Database;

namespace Bootverhuur__t_Sloepke.Classes
{
    public class Vaarplaats : IIProduct
    {
        private static readonly VaarplaatsDatabase Db = new VaarplaatsDatabase();

        public string Naam { get; set; }
        
        public decimal Prijs { get; set; }

        public int Id { get; set; }

        public Vaarplaats()
        {
            
        }

        public Vaarplaats(string naam, int id)
        {
            Naam = naam;
            Prijs = 2;
            Id = id;

        }
        public bool AddVaarplaats(string vaar)
        {
            return Db.AddVaarplaats(vaar);
        }

        public static List<Vaarplaats> GetAllVaarplaatsen(string type)
        {
            return Db.GetVaarplaatsen(type);
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
