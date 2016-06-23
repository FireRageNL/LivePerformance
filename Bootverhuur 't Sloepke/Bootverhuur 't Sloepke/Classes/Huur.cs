using System;
using System.Collections.Generic;
using Bootverhuur__t_Sloepke.Database;

namespace Bootverhuur__t_Sloepke.Classes
{
    public class Huur
    {
        private HuurDatabase _db = new HuurDatabase();
        public Boot Boot { get; set; }

        public List<Materiaal> Materialen { get; set; }

        public string Naam { get; set; }

        public string Huurdernaam { get; set; }

        public string Huurderemail { get; set; }

        public decimal Budget { get; set; }

        public int Meeren { get; set; }
        public List<Vaarplaats> Vaarplaatsen { get; set; }

        public DateTime HuurBegin { get; set; }

        public DateTime HuurEind { get; set; }

        public bool AddHuur(Huur huur)
        {
            return _db.AddHuur(huur);
        }

        public List<Huur> GetAllHuren()
        {
            return _db.GetAllHuren();
        }

        public void ExportHuur(Huur huur)
        {
            //make the stream write dem huur
        }

        public int CalculateVaarplaatsen(decimal budget)
        {
            int bijhuurkosten = 0;
            foreach (Materiaal mat in Materialen)
            {
                bijhuurkosten = (Convert.ToInt32(mat.Prijs) * Convert.ToInt32(HuurEind.Date - HuurBegin.Date));
            }
            budget = budget - ((Boot.Prijs * Convert.ToInt32(HuurEind.Date - HuurBegin.Date)) + bijhuurkosten);

            if (budget <= 5 || Boot.Type == "Kano")
            {
                return (Convert.ToInt32(budget) / 1);
            }

            decimal meren = budget / (decimal)1.5;
            if (meren < 5)
            {
                meren = 5;
            }
            return Convert.ToInt32(meren);
        }
    }
}