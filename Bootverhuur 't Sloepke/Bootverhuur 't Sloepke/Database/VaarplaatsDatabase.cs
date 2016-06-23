using System;
using System.Collections.Generic;
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

        public List<Vaarplaats> GetVaarplaatsen(string type)
        {
            List<Vaarplaats> ret = new List<Vaarplaats>();
            try
            {
                Con.Open();
                Cmd.Parameters.Clear();
                Cmd.CommandText = "SELECT * FROM VAARWATER WHERE VAARWATERID IN(SELECT VAARWATERID FROM TYPEVAARWATER WHERE TYPE = :tp)";
                Cmd.Parameters.Add("tp", type);
                OracleDataReader dr = Cmd.ExecuteReader();
                while (dr.Read())
                {
                    Vaarplaats add = new Vaarplaats(dr.GetString(1),dr.GetInt32(0));
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
    }
}
