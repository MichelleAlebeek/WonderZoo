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

namespace Databasekoppeling
{
    public class Databasekoppeling
    {
        private static OracleConnection connection;

        public Databasekoppeling()
        {    
            string connectie = Settings.Default.ConnectieString;
            connection = new OracleConnection(connectie);
        }

        //public void MethodeNaam()
        //{

        //}
    }
}
