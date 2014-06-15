//Klassen directeur.

namespace Klassen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Directeur : Persoon
    {
        private Beheer beheerder;
        private int leeftijd;
        public Directeur(string naam, int leeftijd, string wachtwoord, string beroep)
            : base (naam, wachtwoord, beroep)
        {
            this.leeftijd = leeftijd;
            this.beheerder = new Beheer();
        }

        public int Leeftijd
        {
            get { return this.leeftijd; }
            set { this.leeftijd = value; }
        }
        public int AantalDieren()
        {
            // Todo het aantal dieren opvragen
            int aantal = this.beheerder.TotaalAantalDieren();
            return aantal;
        }

        public int AantalDierenVerblijf(int huisvestingnummer)
        {
            // Todo het aantal dieren in een verblijf opvragen
            int aantal = this.beheerder.AantalDierenVeblijf(huisvestingnummer);
            return aantal;
        }

        public int BerekenMedicijnDuur(DateTime vandaag, DateTime begindatum)
        {
            // TODO bereken hoelang het medicijn al gebruikt wordt.
            int duur = Convert.ToInt32(begindatum - vandaag);
            return duur;
        }

        public void VerwijderDier(int diernummer, string diernaam)
        {
            // TODO verwijder het dier dier overeenkomt met het diernummer die je meegeeft aan de methode
            this.beheerder.VerwijderDier(diernummer, diernaam);
        }

        public void VoegToe(Dier dier, int huisvestingnummer)
        {
            // TODO voeg het dier toe aan de dierentuin
            this.beheerder.VoegDierToe(dier, huisvestingnummer);
        }

        public List<Medicijn> ZoekMedicijn(int diernummer)
        {
            // TODO zoek bij het meegegeven diernummer het medicijn op die dit dier gebruikt.
            List<Medicijn> medicijn = (List<Medicijn>)this.beheerder.MedicijnVanDier(diernummer);
            return medicijn;
        }

        public string ZoekVerblijfDier(int diernummer)
        {
            // TODO zoek het verblijf die bij het meegegeven diernummer hoort.
            string verblijf = this.beheerder.VerblijfVanDier(diernummer);
            return verblijf;
        }

        public Huisvesting ZoekVerblijf(int diersoortnummer)
        {
            // TODO zoek het verblijf die bij het meegegeven diersoortnummer hoort.
            Huisvesting huisvesting = (Huisvesting)this.beheerder.ZoekHuisvesting(diersoortnummer);
            return huisvesting;
        }
    }
}
