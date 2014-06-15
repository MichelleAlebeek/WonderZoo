using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
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
            vaccinaties = new List<Vaccinatie>();
            diersoorten = new List<Diersoort>();
            beheerder = new Beheer();
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
        public string Hoofddiersoort
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
        public int Leeftijd
        {
            get { return leeftijd; }
            set { leeftijd = value; }
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
            int dieren = beheerder.TotaalAantalDieren();
            return dieren;
        }

        //public void HaalPlattegrondOp() // GEEN MUST HAVE
        //{
        //    // TODO: download de plattegrond
        //}

        public List<String> ZoekVeelvoorkomendeZiektes(int diersoortnummer)
        {
            // TODO zoek de veelvoorkomende ziektes op die bij het diersoort horen met het meegegeven rasnaam
            List<String> veelvoorkomendeziektes = beheerder.VeelVoorkomendeZiektesDiersoort(diersoortnummer);
            return veelvoorkomendeziektes;
        }

        public Dier ZoekDier(string diernaam)
        {
            // TODO zoek het dier in de lijst waarvan de naam overeenkomt met de naam die je meegeeft
            return null;
        }

        public Diersoort ZoekDiersoort(string diersoortnaam)
        {
            // TODO zoek het dier in de lijst met diersoorten waarvan de naam overeenkomt met de naam die je meegeeft
            foreach (Diersoort diersoort in diersoorten)
            {
                if (diersoort.Familie == diersoortnaam)
                {
                    return diersoort;
                }               
            }
            return null;
        }

        public Diersoort ZoekInfoDiersoort(int diersoortnummer)
        {
            // TODO zoek alle info over het diersoort waarvan de naam overeenkomt met de naam die je meegeeft
            Diersoort diersoort = (Diersoort)beheerder.ZoekDiersoort(diersoortnummer);
            return diersoort;
        }

        public Dier ZoekInfoDier(string naamdier)
        { // TODO zoek alle info over het dier waarvan de naam overeenkomt met de naam die je meegeeft
            Dier dier = (Dier)beheerder.InfoDier(naamdier);
            return dier;
        }

        public Ras ZoekRas(int diernummer)
        {
            // TODO zoek het ras op dat bij het dier hoort waarvan de naam overeenkomt met de naam die je meegeeft
            string rasnaam = beheerder.RasVanDier(diernummer);
            foreach (Ras ras in beheerder.Rassen)
            {
                if (ras.Rasnaam == rasnaam)
                {
                    return ras;
                }
            }
            return null;
        }

        public string ZoekVoeding(string naamdier)
        {
            // TODO zoek het voeding op dat bij het dier hoort waarvan de naam overeenkomt met de naam die je meegeeft
            int diersoortnummer;

            foreach (Dier dier in beheerder.Dieren)
            {
                if (dier.Diernaam == naamdier)
                {
                    diersoortnummer = dier.Diersoortnummer;
                    string voeding = beheerder.VoedingDiersoort(diersoortnummer);
                    return voeding;
                }              
            }         
            return null;
        }

        public override string ToString()
        {
            return datumAangenomen + " " + dierverzorgerNummer + " " + geslacht + " " + hoofddiersoort + " " + rekeningnummer  + " " + telefoonnummerPrivé + " " + telefoonnummerZakelijk + " " + typeContract;
        }
    }
}
