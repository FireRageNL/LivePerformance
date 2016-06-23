using System;
using Bootverhuur__t_Sloepke.Classes;
using Oracle.ManagedDataAccess.Client;

namespace Bootverhuur__t_Sloepke.Database
{
    class VaarplaatsDatabase : Database
    {
        public bool AddVaarplaats(Vaarplaats vaar )
        {
            try
            {
                Con.Open();
                Cmd.CommandText = "INSERT INTO VAARWATER(NAAM) VALUES(:nm)";
                Cmd.Parameters.Add("nm", vaar.Naam);
                Cmd.ExecuteNonQuery();
                Con.Close();
                return true;
            }
            catch(OracleException e)
            {
                Console.WriteLine("Oh noes OracleException: " + e.Message);
                Con.Close();
                return false;
            }
        }
    }
}
