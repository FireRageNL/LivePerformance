using System.Collections.Generic;
using Bootverhuur__t_Sloepke.Database;

namespace Bootverhuur__t_Sloepke.Classes
{
    public class Materiaal : IIProduct
    {
        private static MateriaalDatabase _db = new MateriaalDatabase();

        public string Naam { get; set; }

        public decimal Prijs { get; set; }
        
        public string Omschrijving { get; set; }

        public int Id { get; set; }

        public Materiaal(string naam, string omschrijving, int id)
        {
            Naam = naam;
            Prijs = (decimal) 1.25;
            Omschrijving = omschrijving;
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

        public static List<Materiaal> GetAllMateriaal()
        {
            return _db.GetAllMateriaal();
        }

        public override string ToString()
        {
            return Naam + ": " + Omschrijving;
        }
    }
}
