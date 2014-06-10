using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class Persoon
    {
        private int leeftijd;
        private string naam;
        private string wachtwoord;

        public Persoon(string naam, int leeftijd, string wachtwoord)
        {
            this.naam = naam;
            this.leeftijd = leeftijd;
            this.wachtwoord = wachtwoord;
        }

        public int Leeftijd
        {
            get { return leeftijd; }
            set { leeftijd = value; }
        }
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
        public string Wachtwoord
        {
            get { return wachtwoord; }
            set { wachtwoord = value; }
        }

        public override string ToString()
        {
            return naam + leeftijd + wachtwoord;
        }
    }
}
