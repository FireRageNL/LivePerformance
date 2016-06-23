using System;
using System.Collections.Generic;
using Bootverhuur__t_Sloepke.Classes;
using Oracle.ManagedDataAccess.Client;

namespace Bootverhuur__t_Sloepke.Database
{
    class MateriaalDatabase : Database
    {
        public List<Materiaal> GetAllMateriaal()
        {
            List<Materiaal> ret = new List<Materiaal>();
            try
            {
                Con.Open();
                Cmd.CommandText = "SELECT MateriaalID, Naam, Omschrijving FROM MATERIAAL";
                OracleDataReader dr = Cmd.ExecuteReader();
                while (dr.Read())
                {
                    Materiaal add = new Materiaal(dr.GetString(1),dr.GetString(2),dr.GetInt32(0));
                    ret.Add(add);
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

        public bool AddMateriaal(Materiaal materiaal)
        {
            try
            {
                Con.Open();
                Cmd.CommandText = "INSERT INTO MATERIAAL("; // FINISH SQL STATEMENT
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

        public bool EditMateriaal(Materiaal materiaal)
        {
            try
            {
                Con.Open();
                Cmd.CommandText = "UPDATE MATERIAAL SET "; // FINISH SQL STATEMENT
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

        public bool DeleteMateriaal(Materiaal materiaal)
        {
            using (Con)
            try
            {
                Con.Open();
                Cmd.CommandText = "DELETE FROM MATERIAAL WHERE MateriaalID = :mi";
                Cmd.Parameters.Add("mi", materiaal.Id);
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
    }
}
