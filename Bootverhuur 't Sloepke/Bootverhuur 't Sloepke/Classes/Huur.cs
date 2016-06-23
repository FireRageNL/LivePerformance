using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public void ExportHuur(FolderBrowserDialog file)
        {
            string writeloc = file.SelectedPath + "\\Huurcontract - " + this.Huurdernaam + ".txt";
            using (StreamWriter writer = File.CreateText(writeloc))
            {
                writer.WriteLine("Huurder "+ Huurdernaam + " is met Verhuurder "+Naam +" op "+ DateTime.Today.ToShortDateString()+ " Overeengekomen tot de huur van: ");
                writer.WriteLine("Boot: "+ Boot.Naam);
                foreach (Materiaal mat in Materialen)
                {
                    writer.WriteLine("Materiaal: "+ mat.Naam);
                }
                writer.WriteLine("Voor de volgende locaties: ");
                foreach (Vaarplaats vaar in Vaarplaatsen)
                {
                    writer.WriteLine(vaar.Naam);
                }
                writer.WriteLine("Aantal Friese meren: "+ Meeren);
                writer.WriteLine("Voor de tijdsduur: " + HuurBegin.Date.ToShortDateString() + " tot en met "+ HuurEind.Date.ToShortDateString());
                writer.WriteLine("Voor het bedrag van: " +Budget+" euro");
            }
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

        public void UpdateHuurCompletely(string email, string huurder, string verhuurder, Boot boot,
            ListBox.SelectedObjectCollection materiaal, ListBox.SelectedObjectCollection vaarwater, DateTime begin,
            DateTime eind, decimal budget)
        {
            Huurderemail = email;
            Huurdernaam = huurder;
            Naam = verhuurder;
            Boot = boot;
            Budget = budget;
            UpdateData(begin, eind);
            UpdateMateriaal(materiaal);
            UpdateVaarwater(vaarwater);
            CalculateVaarplaatsen(Budget);
        }
        public bool AddHuur(string email, string huurder, string verhuurder, Boot boot, ListBox.SelectedObjectCollection materiaal, ListBox.SelectedObjectCollection vaarwater, DateTime begin, DateTime eind, decimal budget)
        {
            UpdateHuurCompletely(email, huurder, verhuurder, boot, materiaal, vaarwater, begin, eind, budget);
            return _db.AddHuur(this);
        }

        public override string ToString()
        {
            return "Boot:    <" + Boot.Naam +">    verhuurd vanaf:    <"+ HuurBegin.ToShortDateString() + "> tot <"+ HuurEind.ToShortDateString()+">     Aan: <" +Huurdernaam+">";
        }
    }
}