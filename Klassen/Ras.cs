using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    class Ras : Diersoort
    {
        private int draagtijd;
        private int rasgewicht;
        private int leeftijdGevangenschap;
        private int raslengte;
        private string oorspronkelijkeLeefomgeving;
        private int rasleeftijd;
        private string rasnaam;
        private int rasnummer;
        private string status;
        private string wetenschappelijkeNaam;
        private string veelvoorkomendeZiektes;

        public Ras(int rasnummer, string rasnaam, string wetenschappelijkeNaam, string veelvoorkomendeZiektes, int rasleeftijd, int leeftijdGevangenschap, int rasgewicht, int draagtijd, int raslengte, string oorspronkelijkeLeefomgeving, string status, int diersoortnummer, string afdeling, string familie, string diersoortgeslacht, string klasse, string orde)
            : base (diersoortnummer, afdeling, familie, diersoortgeslacht, klasse, orde)
        {
            this.draagtijd = draagtijd;
            this.rasgewicht = rasgewicht;
            this.leeftijdGevangenschap = leeftijdGevangenschap;
            this.raslengte = raslengte;
            this.oorspronkelijkeLeefomgeving = oorspronkelijkeLeefomgeving;
            this.rasleeftijd = rasleeftijd;
            this.rasnaam = rasnaam;
            this.rasnummer = rasnummer;
            this.status = status;
            this.wetenschappelijkeNaam = wetenschappelijkeNaam;
        }
        public string VeelvoorkomendeZiektes
        {
            get { return veelvoorkomendeZiektes; }
            set { veelvoorkomendeZiektes = value; }
        }
        public int Draagtijd
        {
            get { return draagtijd; }
            set { draagtijd = value; }
        }
        public int Rasgewicht
        {
            get { return rasgewicht; }
            set { rasgewicht = value; }
        }
        public int LeeftijdGevangenschap
        {
            get { return leeftijdGevangenschap; }
            set { leeftijdGevangenschap = value; }
        }
        public int Raslengte
        {
            get { return raslengte; }
            set { raslengte = value; }
        }
        public string OorspronkelijkeLeefomgeving
        {
            get { return oorspronkelijkeLeefomgeving; }
            set { oorspronkelijkeLeefomgeving = value; }
        }
        public int Rasleeftijd
        {
            get { return rasleeftijd; }
            set { rasleeftijd = value; }
        }
        public string Rasnaam
        {
            get { return rasnaam ; }
            set { rasnaam = value; }
        }
        public int Rasnummer
        {
            get { return rasnummer; }
            set { rasnummer = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string WetenschappelijkeNaam
        {
            get { return wetenschappelijkeNaam; }
            set { wetenschappelijkeNaam = value; }
        }

        public override string ToString()
        {
            return draagtijd + " " + rasgewicht + " " + leeftijdGevangenschap + " " + raslengte + " " + oorspronkelijkeLeefomgeving + " " + rasleeftijd + " " + rasnaam + " " + rasnummer + " " + status + " " + wetenschappelijkeNaam + " " + veelvoorkomendeZiektes;
        }
    }
}
