namespace Bootverhuur__t_Sloepke.Classes
{
    class Motorboot : Boot
    {
        public int Literinhoud { get; set; }
        
        public int Actieradius { get; set; }

        public Motorboot(int liter, string naam, decimal prijs, string type)
        {
            Literinhoud = liter;
            Actieradius = (liter*15);
            Naam = naam;
            Prijs = prijs;
            Type = type;
        }
    }
}
