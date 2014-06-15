using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class Persoon
    {
        private string naam;
        private string wachtwoord;
        private string beroep;

        public Persoon(string naam, string wachtwoord, string beroep)
        {
            this.naam = naam;
            this.wachtwoord = wachtwoord;
            this.beroep = beroep;
        }

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
        public string Beroep
        {
            get { return beroep; }
            set { beroep = value; }
        }
        public string Wachtwoord
        {
            get { return wachtwoord; }
            set { wachtwoord = value; }
        }

        public override string ToString()
        {
            return naam + wachtwoord;
        }
    }
}
