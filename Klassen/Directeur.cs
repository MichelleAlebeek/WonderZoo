using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class Directeur : Persoon
    {
        private Beheer beheerder;
        public Directeur(string naam, int leeftijd, string wachtwoord)
            : base (naam, leeftijd, wachtwoord)
        {
            beheerder = new Beheer();
        }

        public int AantalDieren()
        {
            // Todo het aantal dieren opvragen
            int aantal = beheerder.TotaalAantalDieren();
            return aantal;
        }

        public int AantalDierenVerblijf(int huisvestingnummer)
        {
            // Todo het aantal dieren in een verblijf opvragen
            int aantal = beheerder.AantalDierenVeblijf(huisvestingnummer);
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
            beheerder.VerwijderDier(diernummer, diernaam);
        }

        public void VoegToe(Dier dier, int huisvestingnummer)
        {
            // TODO voeg het dier toe aan de dierentuin
            beheerder.VoegDierToe(dier, huisvestingnummer);
        }

        public List<Medicijn> ZoekMedicijn(int diernummer)
        {
            // TODO zoek bij het meegegeven diernummer het medicijn op die dit dier gebruikt.
            List<Medicijn> medicijn = (List<Medicijn>)beheerder.MedicijnVanDier(diernummer);
            return medicijn;
        }

        public string ZoekVerblijfDier(int diernummer)
        {
            // TODO zoek het verblijf die bij het meegegeven diernummer hoort.
            string verblijf = beheerder.VerblijfVanDier(diernummer);
            return verblijf;
        }

        public Huisvesting ZoekVerblijf(int diersoortnummer)
        {
            // TODO zoek het verblijf die bij het meegegeven diersoortnummer hoort.
            Huisvesting huisvesting = (Huisvesting)beheerder.ZoekHuisvesting(diersoortnummer);
            return huisvesting;
        }
    }
}
