using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    class Administratie : Persoon
    {
        private int telefoonnummer;
        private List<Diersoort> diersoorten;

        public Administratie(int telefoonnummer, string naam, int leeftijd, string wachtwoord)
            : base(naam, leeftijd, wachtwoord)
        {
            this.telefoonnummer = telefoonnummer;
            diersoorten = new List<Diersoort>();
        }

        public List<Diersoort> Diersoorten
        {
            get { return new List<Diersoort>(diersoorten); }
        }

        public int Telefoonnummer
        {
            get { return telefoonnummer; }
            set { telefoonnummer = value; }
        }

        public int AantalDieren()
        {
            // Todo het aantal dieren opvragen
            return 0;
        }

        public DateTime GeldigTot(string vaccinatienaam)
        {
            // TODO zoek op tot wanneer de vaccinatie geldig is
            return new DateTime(0-00-0000);
        }

        public void PlattegrondAanpassen()
        {
            // TODO pas de plattegrond aan (opnieuw toevoegen)
        }

        public void PlattegrondOpvragen()
        {
            // TODO download de plattegrond
        }

        public void Verwijder(string dierverzorgernaam)
        {
            // TODO verwijder de dierverzorger waarvan de naam overeenkomt met de naam die je meegeeft
        }

        public void VerwijderDierenarts(string dierenartsnaam)
        {
            // TODO verwijder de dierenarts waarvan de naam overeenkomt met de naam die je meegeeft
        }

        public void VoegToe(Dierenarts arts)
        {
            // TODO voeg de dierenarts toe aan de applicatie
        }

        public void VoegToe(Dierverzorger verzorger)
        {
            // TODO voeg de dierverzorger toe aan de applicatie
        }

        public void VoegToe(Dier dier)
        {
            // TODO voeg het dier toe aan de applicatie
        }

        public void VoegToe(Diersoort diersoort)
        {
            // TODO voeg de diersoort toe aan de applicatie
        }

        public void VoegToeVaccinatiedatum (string dierverzorgernaam, DateTime datum)
        {
            // TODO voeg de vaccinatiedatum toe aan de dierverzorger waarvan de naam overeenkomt met de naam die je meegeeft
        }

        public string WerkingsduurVaccinatieOpvragen(string dierverzorgernaam)
        {
            // TODO vraag de werkingsduur van de vaccinatie op waarvan de naam van de dierverzorger overeenkomt met de naam je meegeeft
            return null;
        }

        public Dierenarts Zoek(string dierenartsnaam)
        {
            // TODO geef alle informatie van de dierenarts terug waarvan de naam overeenkomt met de naam die je meegeeft
            return null;
        }

        public Dier ZoekDier(string diernaam)
        {
            // TODO geef alle informatie van het dier terug waarvan de naam overeenkomt met de naam die je meegeeft
            return null;
        }

        public Diersoort ZoekDiersoort(string geslacht)
        {
            // TODO geef alle informatie van de diersoort terug waarvan het geslacht overeenkomt met het geslacht dat je meegeeft
            return null;
        }

        public Medicijn ZoekMedicijn(string diernaam)
        {
            // TODO zoek het medicijn die bij het dier met het meegegeven diernaam hoort
            return null;
        }

        public DateTime ZoekVaccinatieDatum(string dierverzogernaam)
        {
            // TODO zoek de datum van de vaccinatie op van de dierverzorger waarvan de naam overeenkomt met de naam die je meegeeft
            return new DateTime(0-00-0000);
        }

        //public Dierverzorger Zoek(string dierverzorgernaam)
        //{
        //    // TODO zoek alle info die bij de dierverzorger hoort waarvan de naam overeenkomt met de naam die je meegeeft
        //    return null;
        //}

        public override string ToString()
        {
            return Naam + Leeftijd + Wachtwoord + telefoonnummer;
        }
    }
}
