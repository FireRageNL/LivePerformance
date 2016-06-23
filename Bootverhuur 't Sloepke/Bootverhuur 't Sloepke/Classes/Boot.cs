using System.Collections.Generic;
using System.Windows.Forms.VisualStyles;
using Bootverhuur__t_Sloepke.Database;

namespace Bootverhuur__t_Sloepke.Classes
{
    public abstract class Boot : IIProduct
    {
        private static BootDatabase _db = new BootDatabase();
        public string Naam { get; set; }

        public decimal Prijs { get; set; }

        public string Type { get; set; }

        public string Klasse { get; set; }

        public bool AddBoot(Boot boot)
        {
            return _db.AddBoot(boot);
        }

        public bool DeleteBoot(Boot boot)
        {
            return _db.DeleteBoot(boot);
        }

        public bool EditBoot(Boot boot)
        {
            return _db.EditBoot(boot);
        }

        public static List<string> GetTypes()
        {
            return _db.GetTypes();
        }

        public static List<Boot> GetBoats(string type)
        {
            return _db.GetBoats(type);
        }

    }
}

