//Klassen dierenarts. Deze klasse kan alles met betrekking tot medisch gebied. 

namespace Klassen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Dierenarts : Persoon
    {
        private int dierenartsnummer;
        private int rekeningnummer;
        private string specialisatie;
        private int spoednummer;
        private int telefoonnummer;
        private Beheer beheerder;
        private int leeftijd;

        public Dierenarts(int dierenartsnummer, int rekeningnummer, string specialisatie, int spoednummer, int telefoonnummer, string naam, int leeftijd, string wachtwoord, string beroep)
            : base(naam, wachtwoord, beroep)
        {
            this.dierenartsnummer = dierenartsnummer;
            this.rekeningnummer = rekeningnummer;
            this.specialisatie = specialisatie;
            this.spoednummer = spoednummer;
            this.telefoonnummer = telefoonnummer;
            this.leeftijd = leeftijd;
            this.beheerder = new Beheer();
        }

        public int Dierenartsnummer
        {
            get { return this.dierenartsnummer; }
            set { this.dierenartsnummer = value; }
        }
        public int Rekeningnummer
        {
            get { return this.rekeningnummer; }
            set { this.rekeningnummer = value; }
        }
        public int Leeftijd
        {
            get { return this.leeftijd; }
            set { this.leeftijd = value; }
        }
        public string Specialisatie
        {
            get { return this.specialisatie; }
            set { this.specialisatie = value; }
        }
        public int Spoednummer
        {
            get { return this.spoednummer; }
            set { this.spoednummer = value; }
        }
        public int Telefoonnummer
        {
            get { return this.telefoonnummer; }
            set { this.telefoonnummer = value; }
        }

        /// <summary>
        /// berekenen hoelang een medicijn wordt gebruikt
        /// </summary>
        /// <param name="vandaag">datum van vandaag</param>
        /// <param name="begindatum">begin datum</param>
        /// <returns></returns>
        public int BerekenDuurMedicijn(DateTime vandaag, DateTime begindatum)
        {
            // TODO bereken hoelang het medicijn al gebruikt wordt.
            int duur = Convert.ToInt32(begindatum - vandaag);
            return duur;
        }

        /// <summary>
        /// medicijnen van dier opvragen
        /// </summary>
        /// <param name="diernummer">nummer van dier</param>
        /// <returns>een lijst van medicijnen</returns>
        public List<Medicijn> ZoekMedicijn(int diernummer)
        {
            // TODO zoek bij het meegegeven diernummer het medicijn op die dit dier gebruikt.
            List<Medicijn> medicijn = this.beheerder.MedicijnVanDier(diernummer);
            return medicijn;
        }

        /// <summary>
        /// veelvoorkomende ziektes van ras opvragen
        /// </summary>
        /// <param name="rasnaam">naam van het ras</param>
        /// <returns>een lijst van strings met ziektes</returns>
        public List<string> ZoekVeelvoorkomendeZiektes(string rasnaam)
        {
            // TODO zoek de veelvoorkomende ziektes op die bij het ras horen met het meegegeven rasnaam
            int diersoortnummer;
            foreach (Ras ras in this.beheerder.Rassen)
            {
                if (ras.Familie == rasnaam)
                {
                    diersoortnummer = ras.Diersoortnummer;
                    List<string> ziektes = (List<string>)this.beheerder.VeelVoorkomendeZiektesDiersoort(diersoortnummer);
                    return ziektes;
                }
            }          
            return null;
        }

        public override string ToString()
        {
            return this.dierenartsnummer + this.rekeningnummer + this.specialisatie + this.spoednummer + this.telefoonnummer;
        }
    }
}
