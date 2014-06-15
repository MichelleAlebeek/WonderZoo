//Klassen persoon. Deze wordt gebruikt voor het inloggen en dit is de basisklasse (overerving) van alle personen.

namespace Klassen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
            get { return this.naam; }
            set { this.naam = value; }
        }
        public string Beroep
        {
            get { return this.beroep; }
            set { this.beroep = value; }
        }
        public string Wachtwoord
        {
            get { return this.wachtwoord; }
            set { this.wachtwoord = value; }
        }

        public override string ToString()
        {
            return this.naam + this.wachtwoord;
        }
    }
}
