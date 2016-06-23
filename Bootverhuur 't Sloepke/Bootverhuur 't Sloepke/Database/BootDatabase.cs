using System;
using System.Collections.Generic;
using Bootverhuur__t_Sloepke.Classes;
using Oracle.ManagedDataAccess.Client;

namespace Bootverhuur__t_Sloepke.Database
{
    class BootDatabase : Database
    {
        public bool AddBoot(Boot boot)
        {
            try
            {
                Con.Open();
                Cmd.CommandText = "INSERT INTO BOOT("; // FINISH SQL STATEMENT
                //cmd.Parameters.Add() ADD SOME PARAMETERS
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

        public bool EditBoot(Boot boot)
        {
            try
            {
                Con.Open();
                Cmd.CommandText = "UPDATE BOOT SET "; // FINISH SQL STATEMENT
                //cmd.Parameters.Add() ADD SOME PARAMETERS
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

        public bool DeleteBoot(Boot boot)
        {
            try
            {
                Con.Open();
                Cmd.CommandText = "DELETE FROM BOOT WHERE naam = :nm";
                Cmd.Parameters.Add("nm", boot.Naam);
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

        public List<Boot> GetBoats(string type)
        {
            List<Boot> ret = new List<Boot>();
            try
            {
                Con.Open();
                Cmd.CommandText = "SELECT * FROM BOOT WHERE Type = :tp";
                Cmd.Parameters.Add("tp", type);
                OracleDataReader dr = Cmd.ExecuteReader();
                while (dr.Read())
                {
                    //DO THE ADDING STUFF
                }
                Con.Close();
                return ret;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Oh noes OracleException: " + e.Message);
                Con.Close();
                return null;
            }
        }
    }
}
