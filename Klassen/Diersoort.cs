//Klasse diersoort. Dit is een basisklasse voor de overervende klasse(Ras) en de daarop overervende klasse(Dier). Deze klasse bevat alle attributen van een diersoort.

namespace Klassen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Diersoort
    {
        private string afdeling;
        private int diersoortnummer;
        private string familie;
        private string diersoortgeslacht;
        private string klasse;
        private string orde;

        public Diersoort(int diersoortnummer, string afdeling, string familie, string diersoortgeslacht, string klasse, string orde)
        {
            this.afdeling = afdeling;
            this.diersoortnummer = diersoortnummer;
            this.familie = familie;
            this.diersoortgeslacht = diersoortgeslacht;
            this.klasse = klasse;
            this.orde = orde;
        }

        public string Afdeling
        {
            get { return this.afdeling; }
            set { this.afdeling = value; }
        }
        public int Diersoortnummer
        {
            get { return this.diersoortnummer; }
            set { this.diersoortnummer = value; }
        }
        public string Familie
        {
            get { return this.familie; }
            set { this.familie = value; }
        }
        public string Diersoortgeslacht
        {
            get { return this.diersoortgeslacht; }
            set { this.diersoortgeslacht = value; }
        }
        public string Klasse
        {
            get { return this.klasse; }
            set { this.klasse = value; }
        }
        public string Orde
        {
            get { return this.orde; }
            set { this.orde = value; }
        }

        public override string ToString()
        {
            return this.diersoortnummer + " " + this.afdeling + " " + this.klasse + " " + this.orde + " " + this.familie + " " + this.diersoortgeslacht;
        }
    }
}
