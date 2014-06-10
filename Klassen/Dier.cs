using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
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
            medicijnen = new List<Medicijn>();
            voeding = new List<Voeding>();
        }

        public List<Medicijn>Medicijnen
        {
            get { return new List<Medicijn>(medicijnen); }
        }
        public List<Voeding> Voeding
        {
            get { return new List<Voeding>(voeding); }
        }
        public DateTime DatumAanschaf
        {
            get { return datumAanschaf; }
            set { datumAanschaf = value; }
        }
        public string Diernaam
        {
            get { return diernaam; }
            set { diernaam = value; }
        }
        public int Diernummer
        {
            get { return diernummer; }
            set { diernummer = value; }
        }
        public string Geslacht
        {
            get { return geslacht; }
            set { geslacht = value; }
        }
        public double Gewicht
        {
            get { return gewicht; }
            set { gewicht = value; }
        }
        public int Leeftijd
        {
            get { return leeftijd; }
            set { leeftijd = value; }
        }
        public int Lengte
        {
            get { return lengte; }
            set { lengte = value; }
        }
        public string NaamMoeder
        {
            get { return naamMoeder; }
            set { naamMoeder = value; }
        }
        public string NaamVader
        {
            get { return naamVader; }
            set { naamVader = value; }
        }
        public bool Nakomeling
        {
            get { return nakomeling; }
            set { nakomeling = value; }
        }

        public override string ToString()
        {
            return datumAanschaf + diernaam + diernummer + geslacht + gewicht + "leeftijd: " +  leeftijd + "Lengte: " + lengte + naamMoeder + naamVader + nakomeling;
        }

    }
}
