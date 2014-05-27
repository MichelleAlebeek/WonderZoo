using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Oracle.DataAccess;
using System.Configuration;
using System.Configuration;
using Klassen.Properties;
using Klassen;

namespace Databasekoppeling
{
    public class Databasekoppeling
    {
        private string connectie;

        public Databasekoppeling()
        {    
            connectie = Settings.Default.ConnectieString;
          //  connection = new OracleConnection(connectie);
        }

        public Persoon Login(string username, string wachtwoord)
        {
            using (OracleConnection conn = new OracleConnection(connectie))
            {
                OracleCommand cmd = new OracleCommand("select * from gebruiker where gebruikersnaam=:naam and wachtwoord=:wachtwoord", conn);
                
                cmd.Parameters.Add("naam", username);
                cmd.Parameters.Add("wachtwoord", wachtwoord);

                OracleDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    Persoon g = new Persoon(rdr["naam"].ToString(), Convert.ToInt32(rdr["leeftijd"]), rdr["wachtwoord"].ToString());
                    return g;
                }
                return null;
            }

        }
    }
}
