using Bootverhuur__t_Sloepke.Database;

namespace Bootverhuur__t_Sloepke.Classes
{
    public class Vaarplaats : IIProduct
    {
        private VaarplaatsDatabase _db = new VaarplaatsDatabase();

        public string Naam { get; set; }
        
        public decimal Prijs { get; set; }

        public Vaarplaats()
        {
            
        }

        public Vaarplaats(string naam, decimal prijs)
        {
            Naam = naam;
            Prijs = prijs;
        }
        public bool AddVaarplaats(Vaarplaats vaar)
        {
            return _db.AddVaarplaats(vaar);
        }
    }
}
