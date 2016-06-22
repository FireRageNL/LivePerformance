using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bootverhuur__t_Sloepke.Classes;
using Oracle.ManagedDataAccess.Client;

namespace Bootverhuur__t_Sloepke.Database
{
    class MateriaalDatabase : Database
    {
        public MateriaalDatabase()
        {
            
        }

        public List<Materiaal> GetAllMateriaal()
        {
            List<Materiaal> ret = new List<Materiaal>();
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM MATERIAAL";
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

        public bool AddBoot(Materiaal materiaal)
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO MATERIAAL("; // FINISH SQL STATEMENT
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

        public bool EditBoot(Materiaal materiaal)
        {
            try
            {
                con.Open();
                cmd.CommandText = "UPDATE MATERIAAL SET "; // FINISH SQL STATEMENT
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

        public bool DeleteMateriaal(Materiaal materiaal)
        {
            try
            {
                con.Open();
                cmd.CommandText = "DELETE FROM MATERIAAL WHERE MateriaalID = :mi";
                cmd.Parameters.Add("mi", Materiaal.ID);
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
    }
}
