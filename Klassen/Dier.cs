//Klassen dier. Deze klasse bevat alle attributen van een dier.

namespace Klassen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Dier : Ras
    {
        private DateTime datumAanschaf;
        private string diernaam;
        private int diernummer;
        private string geslacht;
        private double gewicht;
        private int leeftijd;
        private int lengte;
        private string naamMoeder;
        private string naamVader;
        private bool nakomeling;
        private List<Medicijn> medicijnen;
        private List<Voeding> voeding;

        public Dier(int diernummer, string diernaam, int leeftijd, string geslacht, int gewicht, int lengte, string naamMoeder, string naamVader, bool nakomeling, DateTime datumAanschaf, int rasnummer, string rasnaam, string wetenschappelijkeNaam, string veelvoorkomendeZiektes, int rasleeftijd, int leeftijdGevangenschap, int rasgewicht, int draagtijd, int raslengte, string oorspronkelijkeLeefomgeving, string status, int diersoortnummer, string afdeling, string familie, string diersoortgeslacht, string klasse, string orde)
            : base (rasnummer, rasnaam, wetenschappelijkeNaam, veelvoorkomendeZiektes, rasleeftijd, leeftijdGevangenschap, rasgewicht, draagtijd, raslengte, oorspronkelijkeLeefomgeving, status, diersoortnummer, afdeling, familie, diersoortgeslacht, klasse, orde)
        {
            this.diernummer = diernummer;
            this.diernaam = diernaam;
            this.leeftijd = leeftijd;
            this.geslacht = geslacht;
            this.gewicht = gewicht;
            this.lengte = lengte;
            this.naamMoeder = naamMoeder;
            this.naamVader = naamVader;
            this.nakomeling = nakomeling;
            this.datumAanschaf = datumAanschaf;
            this.medicijnen = new List<Medicijn>();
            this.voeding = new List<Voeding>();
        }

        public List<Medicijn>Medicijnen
        {
            get { return new List<Medicijn>(this.medicijnen); }
        }
        public List<Voeding> Voeding
        {
            get { return new List<Voeding>(this.voeding); }
        }
        public DateTime DatumAanschaf
        {
            get { return this.datumAanschaf; }
            set { this.datumAanschaf = value; }
        }
        public string Diernaam
        {
            get { return this.diernaam; }
            set { this.diernaam = value; }
        }
        public int Diernummer
        {
            get { return this.diernummer; }
            set { this.diernummer = value; }
        }
        public string Geslacht
        {
            get { return this.geslacht; }
            set { this.geslacht = value; }
        }
        public double Gewicht
        {
            get { return this.gewicht; }
            set { this.gewicht = value; }
        }
        public int Leeftijd
        {
            get { return this.leeftijd; }
            set { this.leeftijd = value; }
        }
        public int Lengte
        {
            get { return this.lengte; }
            set { this.lengte = value; }
        }
        public string NaamMoeder
        {
            get { return this.naamMoeder; }
            set { this.naamMoeder = value; }
        }
        public string NaamVader
        {
            get { return this.naamVader; }
            set { this.naamVader = value; }
        }
        public bool Nakomeling
        {
            get { return this.nakomeling; }
            set { this.nakomeling = value; }
        }

        public override string ToString()
        {
            return this.diernummer + this.diernaam + this.geslacht + this.gewicht + "leeftijd: " + this.leeftijd + "Lengte: " + this.lengte + this.datumAanschaf + this.naamMoeder + this.naamVader + this.nakomeling;
        }

    }
}
