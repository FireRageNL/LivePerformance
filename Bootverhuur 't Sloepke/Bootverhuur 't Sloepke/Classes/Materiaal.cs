using Bootverhuur__t_Sloepke.Database;

namespace Bootverhuur__t_Sloepke.Classes
{
    public class Materiaal : IIProduct
    {
        private MateriaalDatabase _db = new MateriaalDatabase();

        public string Naam { get; set; }

        public decimal Prijs { get; set; }

        public int Id { get; set; }

        public Materiaal()
        {
            
        }

        public Materiaal(string naam, decimal prijs, int id)
        {
            Naam = naam;
            Prijs = prijs;
            Id = id;
        }

        public bool AddMateriaal(Materiaal materiaal)
        {
            return _db.AddMateriaal(materiaal);
        }

        public bool DeleteMateriaal(Materiaal materiaal)
        {
            return _db.DeleteMateriaal(materiaal);
        }

        public bool EditMateriaal(Materiaal materiaal)
        {
            return _db.EditMateriaal(materiaal);
        }
    }
}
