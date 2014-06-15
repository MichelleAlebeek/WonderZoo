//Klasse ras. Dit is de basisklasse van Dier en deze overerft van de klasse diersoort. Deze klassen bevat alle attributen van een ras en een diersoort.

namespace Klassen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ras : Diersoort
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
            get { return this.veelvoorkomendeZiektes; }
            set { this.veelvoorkomendeZiektes = value; }
        }
        public int Draagtijd
        {
            get { return this.draagtijd; }
            set { this.draagtijd = value; }
        }
        public int Rasgewicht
        {
            get { return this.rasgewicht; }
            set { this.rasgewicht = value; }
        }
        public int LeeftijdGevangenschap
        {
            get { return this.leeftijdGevangenschap; }
            set { this.leeftijdGevangenschap = value; }
        }
        public int Raslengte
        {
            get { return this.raslengte; }
            set { this.raslengte = value; }
        }
        public string OorspronkelijkeLeefomgeving
        {
            get { return this.oorspronkelijkeLeefomgeving; }
            set { this.oorspronkelijkeLeefomgeving = value; }
        }
        public int Rasleeftijd
        {
            get { return this.rasleeftijd; }
            set { this.rasleeftijd = value; }
        }
        public string Rasnaam
        {
            get { return this.rasnaam; }
            set { this.rasnaam = value; }
        }
        public int Rasnummer
        {
            get { return this.rasnummer; }
            set { this.rasnummer = value; }
        }
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }
        public string WetenschappelijkeNaam
        {
            get { return this.wetenschappelijkeNaam; }
            set { this.wetenschappelijkeNaam = value; }
        }

        public override string ToString()
        {
            return this.draagtijd + " " + this.rasgewicht + " " + this.leeftijdGevangenschap + " " + this.raslengte + " " + this.oorspronkelijkeLeefomgeving + " " + this.rasleeftijd + " " + this.rasnaam + " " + this.rasnummer + " " + this.status + " " + this.wetenschappelijkeNaam + " " + this.veelvoorkomendeZiektes;
        }
    }
}
