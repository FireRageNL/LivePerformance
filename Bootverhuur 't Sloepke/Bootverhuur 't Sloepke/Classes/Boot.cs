﻿using Bootverhuur__t_Sloepke.Database;

namespace Bootverhuur__t_Sloepke.Classes
{
    public abstract class Boot : IIProduct
    {
        private BootDatabase _db = new BootDatabase();
        public string Naam { get; set; }

        public decimal Prijs { get; set; }

        public string Type { get; set; }

        public bool AddBoot(Boot boot )
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
    }
}
