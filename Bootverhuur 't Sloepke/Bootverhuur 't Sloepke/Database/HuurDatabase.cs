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
                    Cmd.Parameters.Clear();
                    int huurid = dr.GetInt32(0);
                    Cmd.CommandText = "SELECT Naam FROM boothuur WHERE Huurid = :hid";
                    Cmd.Parameters.Add("hid", huurid);
                    OracleDataReader dr2 = Cmd.ExecuteReader();
                    dr2.Read();
                    Boot bname = new Spierkrachtboot();
                    if (dr2.HasRows)
                    {
                        bname.Naam = dr2.GetString(0);
                    }
                    Cmd.CommandText = "SELECT NAAM FROM KLANT WHERE KLANTID = :kid";
                    Cmd.Parameters.Add("kid", dr.GetInt32(1));
                    OracleDataReader dr3 = Cmd.ExecuteReader();
                    dr3.Read();
                    string kname = null;
                    if (dr3.HasRows)
                    {
                        kname = dr3.GetString(0);
                    }
                    Huur add = new Huur
                    {
                        Huurdernaam = kname,
                        Boot =  bname,
                        HuurBegin = dr.GetDateTime(2),
                        HuurEind = dr.GetDateTime(3)
                    };
                    ret.Add(add);
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
