using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bootverhuur__t_Sloepke.Classes;
using Oracle.ManagedDataAccess.Client;

namespace Bootverhuur__t_Sloepke.Database
{
    class HuurDatabase : Database
    {
        public HuurDatabase()
        {
            
        }

        public bool AddHuur(Huur huur)
        {
            try
            {
                con.Open();
                cmd.CommandText = "AddHuur(all fields here)";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Oh noes OracleException: " + e.Message);
                con.Close();
                return false;
            }
        }

        public List<Huur> GetAllHuren()
        {
            List<Huur> ret = new List<Huur>();
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM HUURCONTRACT";
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //DO THE ADDING
                }
                con.Close();
                return ret;
            }
            catch(OracleException e)
            {
                Console.WriteLine("Oh noes OracleException: " + e.Message);
                con.Close();
                return null;
            }
        }
    }
}
