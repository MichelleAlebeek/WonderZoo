using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    class Dierverzorger : Persoon
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

        public Dierverzorger( DateTime datumAangenomen, int dierverzorgerNummer, string geslacht, string hoofddiersoort, int rekeningnummer, int telefoonnummerPrivé, int telefoonnummerZakelijk, string typeContract, string naam, int leeftijd, string wachtwoord)
            : base (naam, leeftijd, wachtwoord)
        {
            this.datumAangenomen = datumAangenomen;
            this.dierverzorgerNummer = dierverzorgerNummer;
            this.geslacht = geslacht;
            this.hoofddiersoort = hoofddiersoort;
            this.rekeningnummer = rekeningnummer;
            this.telefoonnummerPrivé = telefoonnummerPrivé;
            this.telefoonnummerZakelijk = telefoonnummerZakelijk;
            this.typeContract = typeContract;
            vaccinaties = new List<Vaccinatie>();
            diersoorten = new List<Diersoort>();
        }
 
        public List<Vaccinatie> Vacinaties
        {
            get { return new List<Vaccinatie>(vaccinaties); }
        }
        public List<Diersoort> Diersoorten
        {
            get { return new List<Diersoort>(diersoorten); }
        }

        public DateTime DatumAangenomen
        {
            get { return datumAangenomen;}
            set { datumAangenomen = value; }
        }
        public int DierverzorgerNummer
        {
            get { return dierverzorgerNummer; }
            set { dierverzorgerNummer = value; }
        }
        public string Geslacht
        {
            get { return geslacht; }
            set { geslacht = value; }
        }
        public string Hoofddiersoot
        {
            get { return hoofddiersoort; }
            set { hoofddiersoort = value; }
        }
        public int Rekeningnummer
        {
            get { return rekeningnummer; }
            set { rekeningnummer = value; }
        }
        public int TelefoonnummerPrivé
        {
            get { return telefoonnummerPrivé; }
            set { telefoonnummerPrivé = value; }
        }
        public int TelefoonnummerZakelijk
        {
            get { return telefoonnummerZakelijk; }
            set { telefoonnummerZakelijk = value; }
        }
        public string TypeContract
        {
            get { return typeContract; }
            set { typeContract = value; }
        }

        public int AantalDieren()
        {
            // Todo het aantal dieren opvragen
            return 0;
        }

        public void HaalPlattegrondOp()
        {
            // TODO: download de plattegrond
        }

        public string ZoekVeelvoorkomendeZiektes(string rasnaam)
        {
            // TODO zoek de veelvoorkomende ziektes op die bij het ras horen met het meegegeven rasnaam
            return null;
        }

        public Dier ZoekDier(string diernaam)
        {
            // TODO zoek het dier in de lijst met dieren waarvan de naam overeenkomt met de naam die je meegeeft
            return null;
        }

        public Dier ZoekDiersoort(string diersoortnaam)
        {
            // TODO zoek het dier in de lijst met diersoorten waarvan de naam overeenkomt met de naam die je meegeeft
            return null;
        }

        public Diersoort ZoekInfo(string diersoortnaam)
        {
            // TODO zoek alle info over het diersoort waarvan de naam overeenkomt met de naam die je meegeeft
            return null;
        }

        public Dier ZoekInfo(string naamdier)
        { // TODO zoek alle info over het dier waarvan de naam overeenkomt met de naam die je meegeeft
            return null;
        }

        public Ras ZoekRas(string naamdier)
        {
            // TODO zoek het ras op dat bij het dier hoort waarvan de naam overeenkomt met de naam die je meegeeft
            return null;
        }

        public Voeding ZoekVoeding(string naamdier)
        {
            // TODO zoek het voeding op dat bij het dier hoort waarvan de naam overeenkomt met de naam die je meegeeft
            return null;
        }

        public override string ToString()
        {
            return datumAangenomen + " " + dierverzorgerNummer + " " + geslacht + " " + hoofddiersoort + " " + rekeningnummer  + " " + telefoonnummerPrivé + " " + telefoonnummerZakelijk + " " + typeContract;
        }
    }
}
