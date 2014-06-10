using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
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
            get { return afdeling; }
            set { afdeling = value; }
        }
        public int Diersoortnummer
        {
            get { return diersoortnummer; }
            set { diersoortnummer = value; }
        }
        public string Familie
        {
            get { return familie; }
            set { familie = value; }
        }
        public string Diersoortgeslacht
        {
            get { return diersoortgeslacht; }
            set { diersoortgeslacht = value; }
        }
        public string Klasse
        {
            get { return klasse; }
            set { klasse = value; }
        }
        public string Orde
        {
            get { return orde; }
            set { orde = value; }
        }

        public override string ToString()
        {
            return diersoortnummer + afdeling + klasse + orde + familie + diersoortgeslacht;
        }
    }
}
