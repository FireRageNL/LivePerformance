using System;
using System.Collections.Generic;
using System.Data;
using Bootverhuur__t_Sloepke.Classes;
using Oracle.ManagedDataAccess.Client;

namespace Bootverhuur__t_Sloepke.Database
{
    class HuurDatabase : Database
    {
        public bool AddHuur(Huur huur)
        {
            try
            {
                Con.Open();
                Cmd.CommandText = "AddHuur(all fields here)";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.ExecuteNonQuery();
                Con.Close();
                return true;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Oh noes OracleException: " + e.Message);
                Con.Close();
                return false;
            }
        }

        public List<Huur> GetAllHuren()
        {
            List<Huur> ret = new List<Huur>();
            try
            {
                Con.Open();
                Cmd.CommandText = "SELECT * FROM HUURCONTRACT";
                OracleDataReader dr = Cmd.ExecuteReader();
                while (dr.Read())
                {
                    //DO THE ADDING
                }
                Con.Close();
                return ret;
            }
            catch(OracleException e)
            {
                Console.WriteLine("Oh noes OracleException: " + e.Message);
                Con.Close();
                return null;
            }
        }
    }
}
