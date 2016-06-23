using System.Security.Cryptography.X509Certificates;

namespace Bootverhuur__t_Sloepke.Classes
{
    public interface iProduct
    {
        string Naam { get; set; }

        decimal Prijs { get; set; }
    }
}