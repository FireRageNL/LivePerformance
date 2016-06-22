using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bootverhuur__t_Sloepke.Classes;
using Oracle.ManagedDataAccess.Client;

namespace Bootverhuur__t_Sloepke.Database
{
    class BootDatabase : Database
    {
        public BootDatabase()
        {
            
        }

        public bool AddBoot(Boot boot)
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO BOOT("; // FINISH SQL STATEMENT
                //cmd.Parameters.Add() ADD SOME PARAMETERS
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

        public bool EditBoot(Boot boot)
        {
            try
            {
                con.Open();
                cmd.CommandText = "UPDATE BOOT SET "; // FINISH SQL STATEMENT
                //cmd.Parameters.Add() ADD SOME PARAMETERS
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

        public bool DeleteBoot(Boot boot)
        {
            try
            {
                con.Open();
                cmd.CommandText = "DELETE FROM BOOT WHERE naam = :nm";
                cmd.Parameters.Add("nm", boot.Naam);
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

        public List<Boot> GetBoats(string type)
        {
            List<Boot> ret = new List<Boot>();
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM BOOT WHERE Type = :tp";
                cmd.Parameters.Add("tp", type);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //DO THE ADDING STUFF
                }
                con.Close();
                return ret;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Oh noes OracleException: " + e.Message);
                con.Close();
                return null;
            }
        }
    }
}
