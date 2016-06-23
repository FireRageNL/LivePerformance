using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
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
                Cmd.CommandText = "INSERT INTO KLANT(Naam,Email) VALUES(:klnm,:klem) RETURNING KlantID INTO :klantID";
                Cmd.Parameters.Add("klnm", huur.Huurdernaam);
                Cmd.Parameters.Add("klem", huur.Huurderemail);
                Cmd.Parameters.Add(new OracleParameter
                {
                    ParameterName = "klantID",
                    OracleDbType = OracleDbType.Int32,
                    Direction = ParameterDirection.Output
                });
                Cmd.ExecuteNonQuery();
                int klantid = int.Parse(Cmd.Parameters["klantID"].Value.ToString());
                Cmd.CommandText =
                    "INSERT INTO HUUR(Klantid,datumbegin,datumeind,verhuurder) VALUES(:klid,:dbegin,:deind,:verh) RETURNING Huurid INTO :huurID";
                Cmd.Parameters.Add("klid", klantid);
                Cmd.Parameters.Add("dbegin", huur.HuurBegin);
                Cmd.Parameters.Add("deind", huur.HuurEind);
                Cmd.Parameters.Add("verh", huur.Naam);
                Cmd.Parameters.Add(new OracleParameter
                {
                    ParameterName = "huurID",
                    OracleDbType = OracleDbType.Int32,
                    Direction = ParameterDirection.Output
                });
                Cmd.ExecuteNonQuery();
                int huurid = int.Parse(Cmd.Parameters["huurID"].Value.ToString());
                Cmd.CommandText = "INSERT INTO BOOTHUUR(Naam,HuurID) VALUES(:bnm,:hid)";
                Cmd.Parameters.Add("bnm", huur.Boot.Naam);
                Cmd.Parameters.Add("hid", huurid);
                Cmd.ExecuteNonQuery();
                foreach (Materiaal mat in huur.Materialen)
                {
                    Cmd.Parameters.Clear();
                    Cmd.CommandText = "INSERT INTO HUURMATERIAAL(Huurid,Materiaalid) VALUES(:hid,:mtid)";
                    Cmd.Parameters.Add("hid", huurid);
                    Cmd.Parameters.Add("mtid", mat.Id);
                    Cmd.ExecuteNonQuery();
                }
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
                Cmd.CommandText = "SELECT * FROM HUUR";
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
