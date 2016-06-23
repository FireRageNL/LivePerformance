using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
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

        public Huur()
        {
            Materialen = new List<Materiaal>();
            Vaarplaatsen = new List<Vaarplaats>();
            
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
            Meeren = 0;
            decimal bijhuurkosten = Materialen.Aggregate<Materiaal, decimal>(0, (current, mat) => current + (mat.Prijs*(HuurEind.Date - HuurBegin.Date).Days));
            decimal vaarkosten = Vaarplaatsen.Aggregate<Vaarplaats, decimal>(0, (current, vaar) => current + (vaar.Prijs*(HuurEind.Date - HuurBegin.Date).Days));
            budget = budget - ((Boot.Prijs * (HuurEind.Date - HuurBegin.Date).Days) + bijhuurkosten + vaarkosten);

            if (budget <= 5 || Boot.Type == "Kano")
            {
                Meeren = Convert.ToInt32(Math.Floor(budget / 1));
                return Meeren;
            }

            decimal meren = budget / (decimal)1.5;
            if (meren < 5)
            {
                Meeren = 5;
                return Meeren;
            }
            Meeren = Convert.ToInt32(Math.Floor(budget / 1));
            return Meeren;
        }

        public void UpdateBoot(Boot listBoot)
        {
            Boot = listBoot;
        }

        public void UpdateMateriaal(ListBox.SelectedObjectCollection selectedItems)
        {
            Materialen.Clear();
            foreach (object mat in selectedItems)
            {
                Materialen.Add((Materiaal)mat);
            }
        }

        public void UpdateVaarwater(ListBox.SelectedObjectCollection selectedItems)
        {
            Vaarplaatsen.Clear();
            foreach (object vaar in selectedItems)
            {
                Vaarplaatsen.Add((Vaarplaats)vaar);
            }
        }

        public void UpdateData(DateTime dtpBegin, DateTime dtpEind)
        {
            HuurBegin = dtpBegin;
            HuurEind = dtpEind;
        }

        public bool AddHuur(string email, string huurder, string verhuurder, Boot boot, ListBox.SelectedObjectCollection materiaal, ListBox.SelectedObjectCollection vaarwater, DateTime begin, DateTime eind, decimal budget)
        {
            Huurderemail = email;
            Huurdernaam = huurder;
            Naam = verhuurder;
            Boot = boot;
            Budget = budget;
            UpdateData(begin,eind);
            UpdateMateriaal(materiaal);
            UpdateVaarwater(vaarwater);
            CalculateVaarplaatsen(Budget);
            return _db.AddHuur(this);
        }
    }
}