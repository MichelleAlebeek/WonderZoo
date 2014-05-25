using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    class Directeur : Persoon
    {
        public Directeur(string naam, int leeftijd, string wachtwoord)
            : base (naam, leeftijd, wachtwoord)
        {

        }

        public int AantalDieren()
        {
            // Todo het aantal dieren opvragen
            return 0;
        }

        public int AantalDierenVerblijf(int huisvestingnummer)
        {
            // Todo het aantal dieren in een verblijf opvragen
            return 0;
        }

        public int BerekenMedicijnDuur(DateTime vandaag, DateTime begindatum)
        {
            // TODO bereken hoelang het medicijn al gebruikt wordt.
            return 0;
        }

        public void VerwijderDier(int diernummer)
        {
            // TODO verwijder het dier dier overeenkomt met het diernummer die je meegeeft aan de methode
        }

        public void VoegToe(Dier dier)
        {
            // TODO voeg het dier toe aan de dierentuin
        }

        public Medicijn ZoekMedicijn(int diernummer)
        {
            // TODO zoek bij het meegegeven diernummer het medicijn op die dit dier gebruikt.
            return null;
        }

        public Huisvesting ZoekVerblijf(int diernummer)
        {
            // TODO zoek het verblijf die bij het meegegeven diernummer hoort.
            return null;
        }

        public Huisvesting ZoekVerblijf(int diersoortnummer)
        {
            // TODO zoek het verblijf die bij het meegegeven diersoortnummer hoort.
            return null;
        }
    }
}
