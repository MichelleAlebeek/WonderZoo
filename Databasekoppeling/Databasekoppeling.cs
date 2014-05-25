using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Oracle.DataAccess;
using System.Configuration;
using Databasekoppeling.Properties;
using System.Configuration;

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
