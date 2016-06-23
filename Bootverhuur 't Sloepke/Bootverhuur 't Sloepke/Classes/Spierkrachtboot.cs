namespace Bootverhuur__t_Sloepke.Classes
{
    class Spierkrachtboot : Boot
    {
        public Spierkrachtboot(string naam, string klasse)
        {
            Naam = naam;
            Prijs = 10;
            Type = "Spierkrachtboot";
            Klasse = klasse;
        }

        public Spierkrachtboot()
        {
        }

        public override string ToString()
        {
            return Klasse+ " - " +Naam;
        }
    }
}
