using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Oracle.DataAccess;
using System.Configuration;
using Klassen.Properties;
using Klassen;

namespace Databasekoppeling
{
    public class Databasekoppeling
    {
      //  private string connectie;
        private OracleConnection connection;

        public Databasekoppeling()
        {
           // connectie = "Data Source=MyOracleDB;User Id=WonderZoo;Password=Databases1991;";
           // connectie = "User Id=" + "WonderZoo" + " ;Password=" + "Databases1991" + ";Data Source=" + " //localhost:1521/xe" + ";";
          //  connectie = Settings.Default.ConnectieString;
           connection = new OracleConnection( "User Id=" + "WonderZoo" + " ;Password=" + "Databases1991" + ";Data Source=" + "//localhost:1521/xe" + ";");
        }

        #region Inloggen
        public Persoon Login(string username, string wachtwoord)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select * from gebruiker where gebruikersnaam=:naam and wachtwoord=:wachtwoord", conn);

                    cmd.Parameters.Add("naam", username);
                    cmd.Parameters.Add("wachtwoord", wachtwoord);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        Persoon g = new Persoon(rdr["naam"].ToString(), Convert.ToInt32(rdr["leeftijd"]), rdr["wachtwoord"].ToString());
                        return g;
                    }
                    return null;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Dier toevoegen
        public void VoegDierToe(Dier dier, int huisvestingnummer)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("insert into dier values(:diernummer, :diernaam, :leeftijd, :Gewicht, :Lengte, :Geslacht, :Nakomelingen, :DatumAanschaf, :DiersoortNummer, :HuisvestingNummer, :RasNummer, :NaamMoeder, :NaamVader, :NummerMoeder, :NummerVader)", conn);

                    cmd.Parameters.Add("diernummer", dier.Diernummer);
                    cmd.Parameters.Add("diernaam", dier.Diernaam);
                    cmd.Parameters.Add("leeftijd", dier.Leeftijd);
                    cmd.Parameters.Add("Gewicht", dier.Gewicht);
                    cmd.Parameters.Add("Lengte", dier.Lengte);
                    cmd.Parameters.Add("Geslacht", dier.Geslacht);
                    cmd.Parameters.Add("Nakomelingen", dier.Nakomeling);
                    cmd.Parameters.Add("DatumAanschaf", dier.DatumAanschaf);
                    cmd.Parameters.Add("DiersoortNummer", dier.Diersoortnummer);
                    cmd.Parameters.Add("HuisvestingNummer, ", huisvestingnummer);
                    cmd.Parameters.Add("RasNummer", dier.Rasnummer);
                    cmd.Parameters.Add("NaamMoeder", dier.NaamMoeder);
                    cmd.Parameters.Add("NaamVader", dier.NaamVader);
                    cmd.Parameters.Add("NummerMoeder, ", 0);
                    cmd.Parameters.Add("NummerVader)", 0);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Diersoort toevoegen
        public void VoegDiersoortToe(Diersoort diersoort)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("insert into diersoort values(:DiersoortNummer, :Afdeling, :Klasse, :Orde, :Familie, :Geslacht, :DierenartsNummer", conn);

                    cmd.Parameters.Add("DiersoortNummer", diersoort.Diersoortnummer);
                    cmd.Parameters.Add("Afdeling", diersoort.Afdeling);
                    cmd.Parameters.Add("Klasse", diersoort.Klasse);
                    cmd.Parameters.Add("Orde", diersoort.Orde);
                    cmd.Parameters.Add("Familie", diersoort.Familie);
                    cmd.Parameters.Add("Geslacht", diersoort.Diersoortgeslacht);

                    if (diersoort.Orde == "Zoogdieren")
                    {
                        cmd.Parameters.Add("DierenartsNummer", 111);
                    }
                    else if (diersoort.Orde == "Vogels")
                    {
                        cmd.Parameters.Add("DierenartsNummer", 113);
                    }
                    else if (diersoort.Orde == "Reptielen")
                    {
                        cmd.Parameters.Add("DierenartsNummer", 112);
                    }
                    else
                    {
                        cmd.Parameters.Add("DierenartsNummer", null);
                    }

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Vaccinatiedatum toevoegen
        public void VoegVaccinatiedatumToe(int dierverzorgernummer, string vaccinatienaam, DateTime datumgevaccineerd, DateTime datumverlopen, string bijwerking)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("INSERT INTO DIERVERZORGER_VACCINATIE VALUES(:DierverzorgerNummer, :VaccinatieNaam, :DatumGevaccineerd, :DatumVerlopen, :Bijwerking)", conn);

                    cmd.Parameters.Add("DierverzorgerNummer", dierverzorgernummer);
                    cmd.Parameters.Add("VaccinatieNaam", vaccinatienaam);
                    cmd.Parameters.Add("DatumGevaccineerd", datumgevaccineerd);
                    cmd.Parameters.Add("DatumVerlopen", datumverlopen);
                    cmd.Parameters.Add("Bijwerking", bijwerking);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Dier verwijderen // WERKT !!
        public void VerwijderDier(int diernummer, string diernaam)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("delete from dier_medicijn where diernummer = :diernummer", conn);
                    OracleCommand comd = new OracleCommand("delete from dier_voeding where diernummer = :diernummer", conn);
                    OracleCommand comad = new OracleCommand("delete from dier where diernaam = :diernaam", conn);

                    cmd.Parameters.Add("diernummer", diernummer);
                    comd.Parameters.Add("diernummer", diernummer);
                    comad.Parameters.Add("diernaam", diernaam);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    comd.ExecuteNonQuery();
                    comad.ExecuteNonQuery();
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Totaal aantal dieren //  WERKT !!!!
        public int DierenTotaal()
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select count(*) from dier", conn);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        int aantal = Convert.ToInt32(rdr["count(*)"]);
                        return aantal;
                    }
                    return 0;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Verblijf van dier opvragen // WERKT !!!!
        public string VerblijfDierOpvragen(int diernummer)
        {
            using  (OracleConnection conn = connection)//(OracleConnection conn = new OracleConnection(connectie))
            {
                OracleCommand cmd = new OracleCommand("select huisvesting.huisvestingnummer, soorthuisvesting from huisvesting, dier where huisvesting.huisvestingnummer = dier.huisvestingnummer and dier.diernummer = :nummer", conn);    
				cmd.Parameters.Add("nummer", diernummer);
                connection.Open();
                OracleDataReader rdr = cmd.ExecuteReader();
				
				if (rdr.Read())
                {
                    string huisvesting = Convert.ToString(rdr["huisvestingnummer"]) + " " + rdr["soorthuisvesting"].ToString();
                    return huisvesting;
                }
                return null;
            }
        }
        #endregion

        #region Medicijn van dier opvragen // WERKT !!!
        public List<Medicijn> MedicijnDierOpvragen(int diernummer)
        {          
                try
                {
                    using (OracleConnection conn = connection)
                    {
                        OracleCommand cmd = new OracleCommand("select * from dier_medicijn, medicijn where dier_medicijn.medicijnnaam = medicijn.medicijnnaam and diernummer = :nummer", conn);
                        cmd.Parameters.Add("nummer", diernummer);
                        connection.Open();
                        OracleDataReader rdr = cmd.ExecuteReader();

                        List<Medicijn> medicijnen = new List<Medicijn>();

                        if (rdr.Read())
                        {
                            Medicijnnaam medicijnnaam = (Medicijnnaam)Enum.Parse(typeof(Medicijnnaam), Convert.ToString(rdr["medicijnnaam"]));
                            string hoeveelheid = Convert.ToString(rdr["hoeveelheid"]);
                            string bijwerking = Convert.ToString(rdr["bijwerking"]);
                            DateTime startdatum = Convert.ToDateTime(rdr["datum"]);
                            medicijnen.Add(new Medicijn(medicijnnaam, hoeveelheid, bijwerking, startdatum));
                            return medicijnen;
                        }
                        return medicijnen;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
        }
        #endregion

        #region Aantal dieren in verblijf // WERKT !!!
        public int AantalDierenVerblijf(int huisvestingnummer)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select aantaldieren from huisvesting where huisvestingnummer = :nummer", conn);
                    cmd.Parameters.Add("nummer", huisvestingnummer);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        int aantal = Convert.ToInt32(rdr["aantaldieren"]);
                        return aantal;
                    }
                    return 0;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Ras dier opvragen
        public string RasDierOpvragen(int diernummer)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select DISTINCT(rasnaam) from dier, ras where ras.rasnummer = dier.rasnummer and dier.diernummer = :nummer", conn);
                    cmd.Parameters.Add("nummer", diernummer);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        string ras = Convert.ToString(rdr["rasnaam"]);
                        return ras;
                    }
                    return null;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Veelvoorkomende ziektes diersoort
        public string VeelVoorkomendeZiektes(int diersoortnummer)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select DISTINCT (veelvoorkomendeziekte.ziekte) from veelvoorkomendeziekte, ras_ziekte, dier, diersoort where dier.rasnummer = ras_ziekte.rasnummer and veelvoorkomendeziekte.ziekte = ras_ziekte.ziekte and dier.diersoortnummer = diersoort.diersoortnummer and diersoort.diersoortnummer = :nummer", conn);
                    cmd.Parameters.Add("nummer", diersoortnummer);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();
                    string ziektes = "";

                    while (rdr.Read())
                    {
                        string ziekte = Convert.ToString(rdr["veelvoorkomendeziekte.ziekte"]);
                        ziektes = ziektes + ziekte;
                    }
                    return ziektes;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Voeding van diersoort
        public string VoedingDiersoort(int diersoortnummer)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select DISTINCT (voeding.naamvoeding) from voeding, dier_voeding, dier, diersoort where voeding.naamvoeding = dier_voeding.naamvoeding and dier_voeding.diernummer = dier.diernummer and dier.diersoortnummer = diersoort.diersoortnummer and dier.diersoortnummer = :nummer", conn);

                    cmd.Parameters.Add("nummer", diersoortnummer);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        string voeding = Convert.ToString(rdr["voeding.naamvoeding"]);
                        return voeding;
                    }
                    return null;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Huisvesting naam diersoort
        public string HuisvestingnaamDiersoort(int diersoortnummer)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select DISTINCT (huisvesting.soorthuisvesting) from huisvesting, diersoort, dier where huisvesting.huisvestingnummer = dier.huisvestingnummer and dier.diersoortnummer = diersoort.diersoortnummer and dier.diersoortnummer = :nummer", conn);

                    cmd.Parameters.Add("nummer", diersoortnummer);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        string huisvesting = Convert.ToString(rdr["huisvesting.soorthuisvesting"]);
                        return huisvesting;
                    }
                    return null;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Huisvesting diersoort opvragen
        public Huisvesting HuisvestingDiersoort(int diersoortnummer)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select * from huisvesting, diersoort, dier where huisvesting.huisvestingnummer = dier.huisvestingnummer and dier.diersoortnummer = diersoort.diersoortnummer and dier.diersoortnummer = :nummer", conn);

                    cmd.Parameters.Add("nummer", diersoortnummer);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();
                    Huisvesting huisvesting;

                    if (rdr.Read())
                    {
                        int huisvestingnummer = Convert.ToInt32(rdr["huisvesting.nummer"]);
                        HuisvestingSoort soorthuisvesting = (HuisvestingSoort)Enum.Parse(typeof(HuisvestingSoort), Convert.ToString(rdr["soorthuisvesting"]));
                        HuisvestingMateriaal materiaal = (HuisvestingMateriaal)Enum.Parse(typeof(HuisvestingMateriaal), Convert.ToString(rdr["materiaal"]));
                        Gedragsverrijking gedragsverrijking = (Gedragsverrijking)Enum.Parse(typeof(Gedragsverrijking), Convert.ToString(rdr["materiaal"]));
                        int aantaldieren = Convert.ToInt32(rdr["aantal"]);
                        huisvesting = new Huisvesting(huisvestingnummer, soorthuisvesting, materiaal, gedragsverrijking, aantaldieren);
                        return huisvesting;
                    }
                    return null;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Info diersoort
        public Diersoort ZoekDiersoort(int diersoortnummer)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select * from diersoort where diersoort.diersoortnummer = :nummer", conn);

                    cmd.Parameters.Add("nummer", diersoortnummer);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        string afdeling = Convert.ToString(rdr["afdeling"]);
                        string familie = Convert.ToString(rdr["familie"]);
                        string diersoortgeslacht = Convert.ToString(rdr["geslacht"]);
                        string klasse = Convert.ToString(rdr["klasse"]);
                        string orde = Convert.ToString(rdr["orde"]);
                        return new Diersoort(diersoortnummer, afdeling, familie, diersoortgeslacht, klasse, orde);
                    }
                    return null;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Diersoorten
        public List<Diersoort> ZoekDiersoorten()
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select * from diersoort", conn);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    List<Diersoort> diersoorten = new List<Diersoort>();

                    while (rdr.Read())
                    {
                        string afdeling = Convert.ToString(rdr["afdeling"]);
                        string familie = Convert.ToString(rdr["familie"]);
                        string diersoortgeslacht = Convert.ToString(rdr["geslacht"]);
                        string klasse = Convert.ToString(rdr["klasse"]);
                        string orde = Convert.ToString(rdr["orde"]);
                        int diersoortnummer = Convert.ToInt32(rdr["diersoortnummer"]);
                        diersoorten.Add(new Diersoort(diersoortnummer, afdeling, familie, diersoortgeslacht, klasse, orde));                   
                    }
                    return diersoorten;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Info specifiek dier // Overerving ?? dan ook ras en diersoort selecteren
        public Dier InfoDier(string diernaam)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select * from dier where dier.diernaam = :naam", conn);
                    cmd.Parameters.Add("naam", diernaam);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        int diernummer = Convert.ToInt32(rdr["diernummer"]);
                        int leeftijd = Convert.ToInt32(rdr["leeftijd"]);
                        string geslacht = Convert.ToString(rdr["geslacht"]);
                        int gewicht = Convert.ToInt32(rdr["gewicht"]);
                        int lengte = Convert.ToInt32(rdr["lengte"]);
                        string naamMoeder = Convert.ToString(rdr["naamMoeder"]);
                        string naamVader = Convert.ToString(rdr["naamVader"]);
                        bool nakomeling = Convert.ToBoolean(rdr["nakomeling"]);
                        DateTime datumaanschaf = Convert.ToDateTime(rdr["datumaanschaf"]);

                        return new Dier(diernummer, diernaam, leeftijd, geslacht, gewicht, lengte, naamMoeder, naamVader, nakomeling, datumaanschaf, 0, null, null, null, 0, 0, 0, 0, 0, null, null, 0, null, null, null, null, null);

                    }
                    return null;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Begindatum medicijngebruik
        public DateTime BeginMedicijn(string diernaam)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select datum from dier_medicijn, dier where dier_medicijn.diernummer = dier.diernummer and dier.diernaam = :naam", conn);
                    cmd.Parameters.Add("naam", diernaam);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        DateTime datum = Convert.ToDateTime(rdr["datum"]);
                        return datum;
                    }
                    return Convert.ToDateTime("00-00-0000");
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Naam dierverzorgers opvragen
        public List<String> NaamDierverzorgers()
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select dierverzorgernaam from dierverzorger", conn);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    List<String> dierverzorgernaam = new List<string>();

                    if (rdr.Read())
                    {
                        string naam = Convert.ToString(rdr["dierverzorgernaam"]);                        
                        dierverzorgernaam.Add(naam);                
                    }
                    return dierverzorgernaam;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Naam dierverzorger opvragen met dierverzorgernummer
        public string NaamDierverzorger(int dierverzorgernummer)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select dierverzorgernaam from dierverzorger where dierverzorger.dierverzorgernummer = :nummer", conn);
                    cmd.Parameters.Add("nummer", dierverzorgernummer);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        string dierverzorgernaam = Convert.ToString(rdr["dierverzorgernaam"]);
                        return dierverzorgernaam;
                    }
                    return null;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Naam dierenarts opvragen met dierenartsnummer
        public string NaamDierenarts(int dierenartsnummer)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select dierenartsnaam from dierenarts where dierenarts.dierenartsnummer = :nummer", conn);

                    cmd.Parameters.Add("nummer", dierenartsnummer);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        string dierenartsnaam = Convert.ToString(rdr["dierenartsnaam"]);
                        return dierenartsnaam;
                    }
                    return null;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Telefoonnummer dierenarts opvragen met nummer
        public int TelDierenarts(int diernartsnummer)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select telefoonnummer from dierenarts where dierenarts.dierenartsnummer = :nummer", conn);

                    cmd.Parameters.Add("nummer", diernartsnummer);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        int telefoonnummer = Convert.ToInt32(rdr["telefoonnummerprivé"]);
                        return telefoonnummer;
                    }
                    return 0;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Telefoonnummer dierenarts opvragen met naam
        public int TelefoonDierenarts(string dierenartsnaam)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select telefoonnummer from dierenarts where dierenarts.dierenartsnaam = :naam", conn);

                    cmd.Parameters.Add("naam", dierenartsnaam);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        int telefoonnummer = Convert.ToInt32(rdr["telefoonnummerprivé"]);
                        return telefoonnummer;
                    }
                    return 0;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Telefoonnummer privé dierverzorger opvragen met naam
        public int TelPriveDierverzorger(string dierverzorgernaam)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select telefoonnummerprivé from dierverzorger where dierverzorger.dierverzorgernaam = :naam", conn);

                    cmd.Parameters.Add("naam", dierverzorgernaam);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        int telefoonnummer = Convert.ToInt32(rdr["telefoonnummerprivé"]);
                        return telefoonnummer;
                    }
                    return 0;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Telefoonnummer privé dierverzorger opvragen met nummer
        public int TelPriveDierverzorger(int dierverzorgernummer)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select telefoonnummerprivé from dierverzorger where dierverzorger.dierverzorgernummer = :nummer", conn);

                    cmd.Parameters.Add("nummer", dierverzorgernummer);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        int telefoonnummer = Convert.ToInt32(rdr["telefoonnummerprivé"]);
                        return telefoonnummer;
                    }
                    return 0;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Telefoonnummer zakelijk dierverzorger opvragen met naam
        public int TelZakelijkDierverzorger(string dierverzorgernaam)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select telefoonnummerzakelijk from dierverzorger where dierverzorger.dierverzorgernaam = :naam", conn);

                    cmd.Parameters.Add("naam", dierverzorgernaam);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        int telefoonnummer = Convert.ToInt32(rdr["telefoonnummerzakelijk"]);
                        return telefoonnummer;
                    }
                    return 0;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Telefoonnummer zakelijk dierverzorger opvragen met nummer
        public int TelZakelijkDierverzorger(int dierverzorgernummer)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select telefoonnummerzakelijk from dierverzorger where dierverzorger.dierverzorgernummer = :nummer", conn);

                    cmd.Parameters.Add("nummer", dierverzorgernummer);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        int telefoonnummer = Convert.ToInt32(rdr["telefoonnummerzakelijk"]);
                        return telefoonnummer;
                    }
                    return 0;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Rekeningnummer dierverzorger met naam
        public int RekNrDierverzorger(string dierverzorgernaam)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select rekeningnummer from dierverzorger where dierverzorger.dierverzorgernaam = :naam", conn);

                    cmd.Parameters.Add("naam", dierverzorgernaam);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        int rekeningnummer = Convert.ToInt32(rdr["rekeningnummer"]);
                        return rekeningnummer;
                    }
                    return 0;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Rekeningnummer dierenarts met naam
        public int RekNrDierenarts(string dierenartsnaam)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select rekeningnummer from dierenarts where dierenarts.dierenartsnaam = :naam", conn);

                    cmd.Parameters.Add("naam", dierenartsnaam);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        int rekeningnummer = Convert.ToInt32(rdr["rekeningnummer"]);
                        return rekeningnummer;
                    }
                    return 0;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Rekeningnummer dierverzorger met nummer
        public int RekeningnrDierverzorger(int dierverzorgernummer)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select rekeningnummer from dierverzorger where dierverzorger.dierverzorgernummer = :nummer", conn);

                    cmd.Parameters.Add("nummer", dierverzorgernummer);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        int rekeningnummer = Convert.ToInt32(rdr["rekeningnummer"]);
                        return rekeningnummer;
                    }
                    return 0;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Rekeningnummer dierenarts met nummer
        public int RekeningnrDierenarts(int dierenartsnummer)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select rekeningnummer from dierenarts where dierenarts.dierenartsnummer = :nummer", conn);

                    cmd.Parameters.Add("nummer", dierenartsnummer);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        int rekeningnummer = Convert.ToInt32(rdr["rekeningnummer"]);
                        return rekeningnummer;
                    }
                    return 0;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Werkingsduur vaccinatie met vaccinatienaam
        public string WerkingsduurVaccinatie(int vaccinatienaam)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select werkingstijd from vaccinatie where vaccinatie.vaccinatienaam = :naam", conn);

                    cmd.Parameters.Add("naam", vaccinatienaam);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        string werkingstijd = Convert.ToString(rdr["werkingstijd"]);
                        return werkingstijd;
                    }
                    return null;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Werkingsduur vaccinatie met dierverzorgernummer
        public string DuurVaccinatie(int dierverzorgernummer)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select werkingstijd from vaccinatie, dierverzorger_vaccinatie, dierverzorger where vaccinatie.vaccinatienaam = dierverzorger_vaccinatie.vaccinatienaam and dierverzorger_vaccinatie.dierverzorgernummer = dierverzorger.dierverzorgernummer and dierverzorger.dierverzorgernummer = :nummer", conn);

                    cmd.Parameters.Add("nummer", dierverzorgernummer);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        string werkingstijd = Convert.ToString(rdr["werkingstijd"]);
                        return werkingstijd;
                    }
                    return null;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Werkingsduur vaccinatie met dierverzorgernaam
        public string WerkingsduurVaccinatie(string dierverzorgernaam)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select werkingstijd from vaccinatie, dierverzorger_vaccinatie, dierverzorger where vaccinatie.vaccinatienaam = dierverzorger_vaccinatie.vaccinatienaam and dierverzorger_vaccinatie.dierverzorgernummer = dierverzorger.dierverzorgernummer and dierverzorger.dierverzorgernaam = :naam", conn);

                    cmd.Parameters.Add("naam", dierverzorgernaam);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        string werkingstijd = Convert.ToString(rdr["werkingstijd"]);
                        return werkingstijd;
                    }
                    return null;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Vaccinatie verlopen op: met dierverzorgernummer
        public DateTime VaccinatieVerlopenOp(int dierverzorgernummer)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select datumverlopen from  dierverzorger_vaccinatie, dierverzorger where dierverzorger_vaccinatie.dierverzorgernummer = dierverzorger.dierverzorgernummer and dierverzorger.dierverzorgernummer = :nummer", conn);

                    cmd.Parameters.Add("nummer", dierverzorgernummer);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        DateTime datumverlopen = Convert.ToDateTime(rdr["datumverlopen"]);
                        return datumverlopen;
                    }
                    return Convert.ToDateTime(00 - 00 - 0000);
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Vaccinatie verlopen op: met dierverzorgernaam
        public DateTime VaccinatieVerlopen(string dierverzorgernaam)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select datumverlopen from  dierverzorger_vaccinatie, dierverzorger where dierverzorger_vaccinatie.dierverzorgernummer = dierverzorger.dierverzorgernummer and dierverzorger.dierverzorgernaam = :naam", conn);

                    cmd.Parameters.Add("naam", dierverzorgernaam);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        DateTime datumverlopen = Convert.ToDateTime(rdr["datumverlopen"]);
                        return datumverlopen;
                    }
                    return Convert.ToDateTime(00 - 00 - 0000);
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Vaccinaties dierverzorger
        public List<Vaccinatie> VaccinatiesDierverzorger(int dierverzorgernummer)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select vaccinatienaam from  dierverzorger_vaccinatie, dierverzorger where dierverzorger_vaccinatie.dierverzorgernummer = dierverzorger.dierverzorgernummer and dierverzorger.dierverzorgernummer = :nummer", conn);

                    cmd.Parameters.Add("nummer", dierverzorgernummer);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    List<Vaccinatie> vaccinaties = new List<Vaccinatie>();

                    if (rdr.Read())
                    {
                        string vaccinatienaam = Convert.ToString(rdr["vaccinatienaam"]);
                        string werkingstijd = Convert.ToString(rdr["werkingstijd"]);
                        string uitPreventieVoor = Convert.ToString(rdr["uitPreventieVoor"]);
                        double Prijs = Convert.ToDouble(rdr["Prijs"]);
                        vaccinaties.Add(new Vaccinatie(vaccinatienaam, werkingstijd, uitPreventieVoor, Prijs));
                    }
                    return vaccinaties;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Vaccinaties dierverzorger met naam
        public List<Vaccinatie> VaccinatiesDierverzorger(string dierverzorgernaam)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select vaccinatienaam from  dierverzorger_vaccinatie, dierverzorger where dierverzorger_vaccinatie.dierverzorgernummer = dierverzorger.dierverzorgernummer and dierverzorger.dierverzorgernaam = :naam", conn);

                    cmd.Parameters.Add("naam", dierverzorgernaam);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();

                    List<Vaccinatie> vaccinaties = new List<Vaccinatie>();

                    if (rdr.Read())
                    {
                        string vaccinatienaam = Convert.ToString(rdr["vaccinatienaam"]);
                        string werkingstijd = Convert.ToString(rdr["werkingstijd"]);
                        string uitPreventieVoor = Convert.ToString(rdr["uitPreventieVoor"]);
                        double Prijs = Convert.ToDouble(rdr["Prijs"]);
                        vaccinaties.Add(new Vaccinatie(vaccinatienaam, werkingstijd, uitPreventieVoor, Prijs));
                    }
                    return vaccinaties;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Dieverzorger toevoegen // nachecken database (wat waar invoeren??)
        public void DierverzorgerToevoegen(Dierverzorger verzorger)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("insert into dierverzorger values(:nummer, ':naam', ':geslacht', leeftijd, null, aamgenomen, 'contract', telprive, telzakelijk, rekeningnummer, hoofddiersoort, hoofddiersoort)", conn);

                    cmd.Parameters.Add("nummer", verzorger.DierverzorgerNummer);
                    cmd.Parameters.Add("naam", verzorger.Naam);
                    cmd.Parameters.Add("geslacht", verzorger.Geslacht);
                    cmd.Parameters.Add("leeftijd", verzorger.Leeftijd);
                    cmd.Parameters.Add("aamgenomen", verzorger.DatumAangenomen);
                    cmd.Parameters.Add("contract", verzorger.TypeContract);
                    cmd.Parameters.Add("telprive", verzorger.TelefoonnummerPrivé);
                    cmd.Parameters.Add("telzakelijk", verzorger.TelefoonnummerZakelijk);
                    cmd.Parameters.Add("rekeningnummer", verzorger.Rekeningnummer);
                    cmd.Parameters.Add("hoofddiersoort", verzorger.Hoofddiersoot);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Dierverzorger verwijderen
        public void VerwijderDierverzorger(int dierverzorgernummer)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("delete from dierverzorger where dierverzorger.dierverzorgernummer = :nummer", conn);

                    cmd.Parameters.Add("nummer", dierverzorgernummer);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Dierenarts toevoegen
        public void DierenartsToevoegen(Dierenarts arts)
        {
            try
            {
                using (OracleConnection conn = connection)//(OracleConnection conn = new OracleConnection(connectie))
                {
                    OracleCommand cmd = new OracleCommand("insert into dierenarts values(:nummer, ':naam', leeftijd, 'specialisatie', telefoonnummer, rekeningnummer, spoednummer)", conn);

                    cmd.Parameters.Add("nummer", arts.Dierenartsnummer);
                    cmd.Parameters.Add("naam", arts.Dierenartsnummer);
                    cmd.Parameters.Add("leeftijd", arts.Dierenartsnummer);
                    cmd.Parameters.Add("specialisatie", arts.Dierenartsnummer);
                    cmd.Parameters.Add("telefoonnummer", arts.Dierenartsnummer);
                    cmd.Parameters.Add("rekeningnummer", arts.Dierenartsnummer);
                    cmd.Parameters.Add("spoednummer", arts.Dierenartsnummer);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region Dierenarts verwijderen
        public void VerwijderDierenarts(int dierenartsnummer)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("delete from dierenarts where dierenarts.dierenartsnummer = :nummer", conn);

                    cmd.Parameters.Add("nummer", dierenartsnummer);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        //GEEN MUSTHAVES:
        #region Naam dierverzorger aanpassen
        public void DierverzorgernaamAanpassen(string oudenaam, string nieuwenaam)
        {
            using  (OracleConnection conn = connection)//(OracleConnection conn = new OracleConnection(connectie))
            {
                OracleCommand cmd = new OracleCommand("update dierverzorger set dierverzorgernaam = ':nieuwenaam' where dierverzorgernaam = :naam;", conn);

                cmd.Parameters.Add("naam", oudenaam);
                cmd.Parameters.Add("nieuwenaam", nieuwenaam);

                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Naam dierverzorger aanpassen
        public void DerverzorgerAanpassenNaam(int dierverzorgernummer, string nieuwenaam)
        {
            using  (OracleConnection conn = connection)// (OracleConnection conn = new OracleConnection(connectie))
            {
                OracleCommand cmd = new OracleCommand("update dierverzorger set dierverzorgernaam = ':nieuwenaam' where dierverzorgernummer = :nummer;", conn);

                cmd.Parameters.Add("nummer", dierverzorgernummer);
                cmd.Parameters.Add("nieuwenaam", nieuwenaam);

                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Naam dierenarts aanpassen
        public void DierenartsnaamAanpassen(string oudenaam, string nieuwenaam)
        {
            using  (OracleConnection conn = connection)//(OracleConnection conn = new OracleConnection(connectie))
            {
                OracleCommand cmd = new OracleCommand("update dierenarts set dierenartsnaam = ':nieuwenaam' where dierenartsnaam = :naam;", conn);

                cmd.Parameters.Add("naam", oudenaam);
                cmd.Parameters.Add("nieuwenaam", nieuwenaam);

                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Naam dierenarts aanpassen
        public void DierenartsnaamAanpassen(int dierenartsnummer, string nieuwenaam)
        {
            using  (OracleConnection conn = connection)//(OracleConnection conn = new OracleConnection(connectie))
            {
                OracleCommand cmd = new OracleCommand("update dierenarts set dierenartsnaam = ':nieuwenaam' where dierenartsnummer = :nummer;", conn);

                cmd.Parameters.Add("nummer", dierenartsnummer);
                cmd.Parameters.Add("nieuwenaam", nieuwenaam);

                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Telefoonnummer dierenarts aanpassen
        public void VeranderTelArts(int dierenartsnummer, int telefoonnummer)
        {
            using  (OracleConnection conn = connection)// (OracleConnection conn = new OracleConnection(connectie))
            {
                OracleCommand cmd = new OracleCommand("update dierenarts set telefoonnummer = :telnr where dierenartsnummer = :nummer;", conn);

                cmd.Parameters.Add("nummer", dierenartsnummer);
                cmd.Parameters.Add("telnr", telefoonnummer);

                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Telefoonnummer dierenarts aanpassen
        public void VeranderTelDierenarts(int dierenartsnaam, int telefoonnummer)
        {
            using  (OracleConnection conn = connection)//(OracleConnection conn = new OracleConnection(connectie))
            {
                OracleCommand cmd = new OracleCommand("update dierenarts set telefoonnummer = :telnr where dierenartsnaam = :naam;", conn);

                cmd.Parameters.Add("naam", dierenartsnaam);
                cmd.Parameters.Add("telnr", telefoonnummer);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Telefoonnummer privé dierverzorger aanpassen
        public void VeranderTelPrive(int dierverzorgernummer, int telefoonnummerprive)
        {
            using  (OracleConnection conn = connection)// (OracleConnection conn = new OracleConnection(connectie))
            {
                OracleCommand cmd = new OracleCommand("update dierverzorger set telefoonnummerprivé = :telnr where dierverzorgernummer = :nummer;", conn);

                cmd.Parameters.Add("nummer", dierverzorgernummer);
                cmd.Parameters.Add("telnr", telefoonnummerprive);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Telefoonnummer privé dierverzorger aanpassen
        public void VeranderTelPriveVerzorger(int dierverzorgernaam, int telefoonnummerprive)
        {
            using  (OracleConnection conn = connection)// (OracleConnection conn = new OracleConnection(connectie))
            {
                OracleCommand cmd = new OracleCommand("update dierverzorger set telefoonnummerprivé = :telnr where dierverzorgernaam = :naam;", conn);

                cmd.Parameters.Add("naam", dierverzorgernaam);
                cmd.Parameters.Add("telnr", telefoonnummerprive);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Telefoonnummer zakelijk dierverzorger aanpassen
        public void VeranderTelZakelijk(int dierverzorgernummer, int telefoonnummerprive)
        {
            using  (OracleConnection conn = connection)// (OracleConnection conn = new OracleConnection(connectie))
            {
                OracleCommand cmd = new OracleCommand("update dierverzorger set telefoonnummerzakelijk = :telnr where dierverzorgernummer = :nummer;", conn);

                cmd.Parameters.Add("nummer", dierverzorgernummer);
                cmd.Parameters.Add("telnr", telefoonnummerprive);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Telefoonnummer zakelijk dierverzorger aanpassen
        public void VeranderTelZakelijkVerzorger(int dierverzorgernaam, int telefoonnummerprive)
        {
            using  (OracleConnection conn = connection)// (OracleConnection conn = new OracleConnection(connectie))
            {
                OracleCommand cmd = new OracleCommand("update dierverzorger set telefoonnummerzakelijk = 123 where dierverzorgernaam = :naam;", conn);

                cmd.Parameters.Add("naam", dierverzorgernaam);
                cmd.Parameters.Add("telnr", telefoonnummerprive);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Rekeningnummer dierverzorger aanpassen met nummer
        public void VeranderReknrVerzorger(int dierverzorgernummer, int rekeningnummer)
        {
            using  (OracleConnection conn = connection)//(OracleConnection conn = new OracleConnection(connectie))
            {
                OracleCommand cmd = new OracleCommand("update dierverzorger set rekeningnummer = :reknr where dierverzorgernummer = :nummer;", conn);

                cmd.Parameters.Add("nummer", dierverzorgernummer);
                cmd.Parameters.Add("reknr", rekeningnummer);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Rekeningnummer dierverzorger aanpassen met naam
        public void VeranderRekeningnrVerzorger(int dierverzorgernaam, int rekeningnummer)
        {
            using  (OracleConnection conn = connection)// (OracleConnection conn = new OracleConnection(connectie))
            {
                OracleCommand cmd = new OracleCommand("update dierverzorger set rekeningnummer = :reknr where dierverzorgernaam = :naam;", conn);

                cmd.Parameters.Add("naam", dierverzorgernaam);
                cmd.Parameters.Add("reknr", rekeningnummer);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Rekeningnummer dierenarts aanpassen met nummer
        public void VeranderReknrDierenarts(int dierenartsnummer, int rekeningnummer)
        {
            using  (OracleConnection conn = connection)// (OracleConnection conn = new OracleConnection(connectie))
            {
                OracleCommand cmd = new OracleCommand("update dierenarts set rekeningnummer = :reknr where dierenartsnummer = :nummer;", conn);

                cmd.Parameters.Add("nummer", dierenartsnummer);
                cmd.Parameters.Add("reknr", rekeningnummer);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Rekeningnummer dierenarts aanpassen met naam
        public void VeranderRekeningnrArts(int dierenartsnaam, int rekeningnummer)
        {
            using  (OracleConnection conn = connection)//(OracleConnection conn = new OracleConnection(connectie))
            {
                OracleCommand cmd = new OracleCommand("update dierenarts set rekeningnummer = :reknr where dierenartsnaam = :naam;", conn);

                cmd.Parameters.Add("naam", dierenartsnaam);
                cmd.Parameters.Add("reknr", rekeningnummer);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Nieuwe vaccinatie opslaan // nachecken met database
        public void NieuweVaccinatie(Vaccinatie vaccinatie, int dierverzorgernummer, int vaccinatienummer, DateTime datum, DateTime einddatum, string bijwerking)
        {
            using  (OracleConnection conn = connection)// (OracleConnection conn = new OracleConnection(connectie))
            {
                OracleCommand cmd = new OracleCommand("insert into dierverzorger_vaccinatie VALUES(:nummer, ':vcnummer', 'datum', 'einddatum', ':bijwerking' );", conn);

                cmd.Parameters.Add("nummer", dierverzorgernummer);
                cmd.Parameters.Add("vcnummer", vaccinatienummer);
                cmd.Parameters.Add("datum", datum);
                cmd.Parameters.Add("einddatum", einddatum);
                cmd.Parameters.Add("bijwerking", bijwerking);

                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Nieuwe medicijn opslaan // nachecken met database 
        public void NieuweVaccinatie(Medicijn medicijn)
        {
            using  (OracleConnection conn = connection)//(OracleConnection conn = new OracleConnection(connectie))
            {
                OracleCommand cmd = new OracleCommand("insert into medicijn VALUES(':naam', :hoeveel, ':datum', ':bijwerking' );", conn);

                cmd.Parameters.Add("naam", medicijn.Medicijnnaam);
                cmd.Parameters.Add("hoeveel", medicijn.Hoeveelheid);
                cmd.Parameters.Add("datum", medicijn.Startdatum);
                cmd.Parameters.Add("bijwerking", medicijn.Bijwerking);

                cmd.ExecuteNonQuery();
            }
        }
        #endregion

    }
}
