//Klasse dierverzorger. Deze klasse kan alles wat betrekking heeft tot de verzorging van de dieren. 

namespace Klassen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Dierverzorger : Persoon
    {
        private DateTime datumAangenomen;
        private int dierverzorgerNummer;
        private string geslacht;
        private string hoofddiersoort;
        private int rekeningnummer;
        private int telefoonnummerPrivé;
        private int telefoonnummerZakelijk;
        private string typeContract;
        private List<Vaccinatie> vaccinaties;
        private List<Diersoort> diersoorten;
        private Beheer beheerder;
        private int leeftijd;

        public Dierverzorger( DateTime datumAangenomen, int dierverzorgerNummer, string geslacht, string hoofddiersoort, int rekeningnummer, int telefoonnummerPrivé, int telefoonnummerZakelijk, string typeContract, string naam, int leeftijd, string wachtwoord, string beroep)
            : base (naam, wachtwoord, beroep)
        {
            this.datumAangenomen = datumAangenomen;
            this.dierverzorgerNummer = dierverzorgerNummer;
            this.geslacht = geslacht;
            this.hoofddiersoort = hoofddiersoort;
            this.rekeningnummer = rekeningnummer;
            this.telefoonnummerPrivé = telefoonnummerPrivé;
            this.telefoonnummerZakelijk = telefoonnummerZakelijk;
            this.typeContract = typeContract;
            this.leeftijd = leeftijd;
            this.vaccinaties = new List<Vaccinatie>();
            this.diersoorten = new List<Diersoort>();
            this.beheerder = new Beheer();
        }
 
        public List<Vaccinatie> Vacinaties
        {
            get { return new List<Vaccinatie>(this.vaccinaties); }
        }
        public List<Diersoort> Diersoorten
        {
            get { return new List<Diersoort>(this.diersoorten); }
        }

        public DateTime DatumAangenomen
        {
            get { return this.datumAangenomen; }
            set { this.datumAangenomen = value; }
        }
        public int DierverzorgerNummer
        {
            get { return this.dierverzorgerNummer; }
            set { this.dierverzorgerNummer = value; }
        }
        public string Geslacht
        {
            get { return this.geslacht; }
            set { this.geslacht = value; }
        }
        public string Hoofddiersoort
        {
            get { return this.hoofddiersoort; }
            set { this.hoofddiersoort = value; }
        }
        public int Rekeningnummer
        {
            get { return this.rekeningnummer; }
            set { this.rekeningnummer = value; }
        }
        public int TelefoonnummerPrivé
        {
            get { return this.telefoonnummerPrivé; }
            set { this.telefoonnummerPrivé = value; }
        }
        public int Leeftijd
        {
            get { return this.leeftijd; }
            set { this.leeftijd = value; }
        }
        public int TelefoonnummerZakelijk
        {
            get { return this.telefoonnummerZakelijk; }
            set { this.telefoonnummerZakelijk = value; }
        }
        public string TypeContract
        {
            get { return this.typeContract; }
            set { this.typeContract = value; }
        }

        /// <summary>
        /// het totaal aantal dieren opvragen
        /// </summary>
        /// <returns>aantal dieren</returns>
        public int AantalDieren()
        {
            // Todo het aantal dieren opvragen
            int dieren = this.beheerder.TotaalAantalDieren();
            return dieren;
        }

        //public void HaalPlattegrondOp() // GEEN MUST HAVE
        //{
        //    // TODO: download de plattegrond
        //}

        /// <summary>
        /// veelvoorkomende ziektes van een diersoort ovpragen
        /// </summary>
        /// <param name="diersoortnummer">nummer van diersoort</param>
        /// <returns>lijst van strings met de ziektes</returns>
        public List<string> ZoekVeelvoorkomendeZiektes(int diersoortnummer)
        {
            // TODO zoek de veelvoorkomende ziektes op die bij het diersoort horen met het meegegeven rasnaam
            List<string> veelvoorkomendeziektes = this.beheerder.VeelVoorkomendeZiektesDiersoort(diersoortnummer);
            return veelvoorkomendeziektes;
        }

        /// <summary>
        /// een dier zoeken
        /// </summary>
        /// <param name="diernaam">naam van het dier</param>
        /// <returns>een dier</returns>
        public Dier ZoekDier(string diernaam)
        {
            // TODO zoek het dier in de lijst waarvan de naam overeenkomt met de naam die je meegeeft
            return null;
        }

        /// <summary>
        /// een diersoort zoeken
        /// </summary>
        /// <param name="diersoortnaam">naam van diersoort</param>
        /// <returns>een diersoort</returns>
        public Diersoort ZoekDiersoort(string diersoortnaam)
        {
            // TODO zoek het dier in de lijst met diersoorten waarvan de naam overeenkomt met de naam die je meegeeft
            foreach (Diersoort diersoort in this.diersoorten)
            {
                if (diersoort.Familie == diersoortnaam)
                {
                    return diersoort;
                }               
            }
            return null;
        }

        /// <summary>
        /// info diersoort opvragen
        /// </summary>
        /// <param name="diersoortnummer">nummer diersoort</param>
        /// <returns>een diersoort</returns>
        public Diersoort ZoekInfoDiersoort(int diersoortnummer)
        {
            // TODO zoek alle info over het diersoort waarvan de naam overeenkomt met de naam die je meegeeft
            Diersoort diersoort = (Diersoort)this.beheerder.ZoekDiersoort(diersoortnummer);
            return diersoort;
        }

        /// <summary>
        /// info van dier opvragen
        /// </summary>
        /// <param name="naamdier">naam van dier</param>
        /// <returns>een dier</returns>
        public Dier ZoekInfoDier(string naamdier)
        { // TODO zoek alle info over het dier waarvan de naam overeenkomt met de naam die je meegeeft
            Dier dier = (Dier)this.beheerder.InfoDier(naamdier);
            return dier;
        }

        /// <summary>
        /// ras van een dier opvragen
        /// </summary>
        /// <param name="diernummer">nummer van het dier</param>
        /// <returns>een ras</returns>
        public Ras ZoekRas(int diernummer)
        {
            // TODO zoek het ras op dat bij het dier hoort waarvan de naam overeenkomt met de naam die je meegeeft
            string rasnaam = this.beheerder.RasVanDier(diernummer);
            foreach (Ras ras in this.beheerder.Rassen)
            {
                if (ras.Rasnaam == rasnaam)
                {
                    return ras;
                }
            }
            return null;
        }

        /// <summary>
        /// voeding van een dier opvragen
        /// </summary>
        /// <param name="naamdier">naam van dier</param>
        /// <returns>naam van de voeding</returns>
        public string ZoekVoeding(string naamdier)
        {
            // TODO zoek het voeding op dat bij het dier hoort waarvan de naam overeenkomt met de naam die je meegeeft
            int diersoortnummer;

            foreach (Dier dier in this.beheerder.Dieren)
            {
                if (dier.Diernaam == naamdier)
                {
                    diersoortnummer = dier.Diersoortnummer;
                    string voeding = this.beheerder.VoedingDiersoort(diersoortnummer);
                    return voeding;
                }              
            }         
            return null;
        }

        public override string ToString()
        {
            return this.datumAangenomen + " " + this.dierverzorgerNummer + " " + this.geslacht + " " + this.hoofddiersoort + " " + this.rekeningnummer + " " + this.telefoonnummerPrivé + " " + this.telefoonnummerZakelijk + " " + this.typeContract;
        }
    }
}
