using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bootverhuur__t_Sloepke.Classes;
using Oracle.ManagedDataAccess.Client;

namespace Bootverhuur__t_Sloepke.Database
{
    class VaarplaatsDatabase : Database
    {
        public VaarplaatsDatabase()
        {
            
        }

        public bool AddVaarplaats(Vaarplaats vaar )
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO VAARWATER(NAAM) VALUES(:nm)";
                cmd.Parameters.Add("nm", vaar.Naam);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch(OracleException e)
            {
                Console.WriteLine("Oh noes OracleException: " + e.Message);
                con.Close();
                return false;
            }
        }
    }
}
