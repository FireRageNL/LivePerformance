namespace Bootverhuur__t_Sloepke.Classes
{
    class Motorboot : Boot
    {
        public int Literinhoud { get; set; }
        
        public int Actieradius { get; set; }

        public Motorboot(int liter, string naam, string klasse)
        {
            Literinhoud = liter;
            Actieradius = (liter*15);
            Naam = naam;
            Prijs = 15;
            Klasse = klasse;
            Type = "Motorboot";
        }

        public override string ToString()
        {
            return Klasse + " - " + Naam + " Actieradius: " + Actieradius;
        }
    }
}
