//Klassen directeur. Deze klasse kan alles wat betrekking heeft tot het leiden van het bedrijf.

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

        /// <summary>
        /// totaal aantal dieren opvragen
        /// </summary>
        /// <returns>totaal aantal dieren</returns>
        public int AantalDieren()
        {
            // Todo het aantal dieren opvragen
            int aantal = this.beheerder.TotaalAantalDieren();
            return aantal;
        }

        /// <summary>
        /// aantal dieren in een verblijf opvragen
        /// </summary>
        /// <param name="huisvestingnummer">nummer van huisvesting</param>
        /// <returns>aantal dieren in het verblijf</returns>
        public int AantalDierenVerblijf(int huisvestingnummer)
        {
            // Todo het aantal dieren in een verblijf opvragen
            int aantal = this.beheerder.AantalDierenVeblijf(huisvestingnummer);
            return aantal;
        }

        /// <summary>
        /// duur van medicijn berekenen
        /// </summary>
        /// <param name="vandaag">datum van vandaag</param>
        /// <param name="begindatum">datum begin met medicijn</param>
        /// <returns>hoelang het medicijn gebruikt wordt</returns>
        public int BerekenMedicijnDuur(DateTime vandaag, DateTime begindatum)
        {
            // TODO bereken hoelang het medicijn al gebruikt wordt.
            int duur = Convert.ToInt32(begindatum - vandaag);
            return duur;
        }

        /// <summary>
        /// een dier verwijderen
        /// </summary>
        /// <param name="diernummer">nummer van het dier</param>
        /// <param name="diernaam">naam van het dier</param>
        public void VerwijderDier(int diernummer, string diernaam)
        {
            // TODO verwijder het dier dier overeenkomt met het diernummer die je meegeeft aan de methode
            this.beheerder.VerwijderDier(diernummer, diernaam);
        }

        /// <summary>
        /// dier toevoegen 
        /// </summary>
        /// <param name="dier">een dier</param>
        /// <param name="huisvestingnummer">nummer van huisvesting waar het dier komt</param>
        public void VoegToe(Dier dier, int huisvestingnummer)
        {
            // TODO voeg het dier toe aan de dierentuin
            this.beheerder.VoegDierToe(dier, huisvestingnummer);
        }

        /// <summary>
        /// medicijnen van het dier opvragen
        /// </summary>
        /// <param name="diernummer">nummer van het dier</param>
        /// <returns>een lijst van medicijnen van het dier</returns>
        public List<Medicijn> ZoekMedicijn(int diernummer)
        {
            // TODO zoek bij het meegegeven diernummer het medicijn op die dit dier gebruikt.
            List<Medicijn> medicijn = (List<Medicijn>)this.beheerder.MedicijnVanDier(diernummer);
            return medicijn;
        }

        /// <summary>
        /// verblijf van het dier zoeken
        /// </summary>
        /// <param name="diernummer">nummer van het dier</param>
        /// <returns>naam van het verblijf</returns>
        public string ZoekVerblijfDier(int diernummer)
        {
            // TODO zoek het verblijf die bij het meegegeven diernummer hoort.
            string verblijf = this.beheerder.VerblijfVanDier(diernummer);
            return verblijf;
        }

        /// <summary>
        /// verblijf van diersoort zoeken
        /// </summary>
        /// <param name="diersoortnummer">nummer van diersoort</param>
        /// <returns>een huisvesting</returns>
        public Huisvesting ZoekVerblijf(int diersoortnummer)
        {
            // TODO zoek het verblijf die bij het meegegeven diersoortnummer hoort.
            Huisvesting huisvesting = (Huisvesting)this.beheerder.ZoekHuisvesting(diersoortnummer);
            return huisvesting;
        }
    }
}
