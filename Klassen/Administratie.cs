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
        private Beheer beheerder;

        public Administratie(int telefoonnummer, string naam, int leeftijd, string wachtwoord)
            : base(naam, leeftijd, wachtwoord)
        {
            this.telefoonnummer = telefoonnummer;
            diersoorten = new List<Diersoort>();
            beheerder = new Beheer();
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
            int aantal = beheerder.TotaalAantalDieren();
            return aantal;
        }

        public DateTime GeldigTot(string dierverzorgernaam)
        {
            // TODO zoek op tot wanneer de vaccinatie geldig is
            DateTime geldigtot = beheerder.VaccinatieVerlopenOp(dierverzorgernaam);
            return geldigtot;
        }

        // GEEN MUSTHAVE
        //public void PlattegrondAanpassen() 
        //{
        //    // TODO pas de plattegrond aan (opnieuw toevoegen)
        //}

        // GEEN MUSTHAVE
        //public void PlattegrondOpvragen()
        //{
        //    // TODO download de plattegrond
        //}

        public void Verwijder(int dierverzorgernummer)
        {
            // TODO verwijder de dierverzorger waarvan de naam overeenkomt met de naam die je meegeeft
            beheerder.Verwijder(dierverzorgernummer);
        }

        public void VerwijderDierenarts(int dierenartsnummer)
        {
            // TODO verwijder de dierenarts waarvan de naam overeenkomt met de naam die je meegeeft
            beheerder.VerwijderArts(dierenartsnummer);
        }

        public void VoegToe(Dierenarts arts)
        {
            // TODO voeg de dierenarts toe aan de applicatie
            beheerder.VoegToe(arts);
        }

        public void VoegToe(Dierverzorger verzorger)
        {
            // TODO voeg de dierverzorger toe aan de applicatie
            beheerder.VoegToe(verzorger);
        }

        public void VoegToe(Dier dier, int huisvestingnummer)
        {
            // TODO voeg het dier toe aan de applicatie
            beheerder.VoegDierToe(dier, huisvestingnummer);
        }

        public void VoegToe(Diersoort diersoort)
        {
            // TODO voeg de diersoort toe aan de applicatie
            beheerder.VoegToeDiersoort(diersoort);
        }

        public void VoegToeVaccinatiedatum (int dierverzorgernummer, string vaccinatienaam, DateTime datumgevaccineerd, DateTime datumverlopen, string bijwerking)
        {
            // TODO voeg de vaccinatiedatum toe aan de dierverzorger waarvan de naam overeenkomt met de naam die je meegeeft
            beheerder.VoegToeVaccinatiedatum(dierverzorgernummer, vaccinatienaam, datumgevaccineerd, datumverlopen, bijwerking);
        }

        public string WerkingsduurVaccinatieOpvragen(int dierverzorgernummer)
        {
            // TODO vraag de werkingsduur van de vaccinatie op waarvan de naam van de dierverzorger overeenkomt met de naam je meegeeft
            string werkingsduur = beheerder.WerkingsduurVaccinatie(dierverzorgernummer);
            return werkingsduur;
        }

        public Dierenarts ZoekArts(string dierenartsnaam)
        {
            // TODO geef alle informatie van de dierenarts terug waarvan de naam overeenkomt met de naam die je meegeeft
            foreach(Dierenarts arts in beheerder.Dierenartsen)
            {
                if(arts.Naam == dierenartsnaam)
                {
                    return arts;
                }
            }
            return null;
        }

        public Dier ZoekDier(string diernaam)
        {
            // TODO geef alle informatie van het dier terug waarvan de naam overeenkomt met de naam die je meegeeft
            foreach (Dier dier in beheerder.Dieren)
            {
                if (dier.Diernaam == diernaam)
                {
                    return dier;
                }
            }
            return null;
        }

        public Diersoort ZoekDiersoort(string geslacht)
        {
            // TODO geef alle informatie van de diersoort terug waarvan het geslacht overeenkomt met het geslacht dat je meegeeft
            foreach (Diersoort diersoort in beheerder.Diersoorten)
            {
                if (diersoort.Diersoortgeslacht == geslacht)
                {
                    int diersoortnummer = diersoort.Diersoortnummer;
                    Diersoort diersoortje = beheerder.ZoekDiersoort(diersoortnummer);
                    return diersoortje;
                }
            }        
            return null;
        }

        public List<Medicijn> ZoekMedicijn(string diernaam)
        {
            // TODO zoek het medicijn die bij het dier met het meegegeven diernaam hoort
            List<Medicijn> medicijnen = new List<Medicijn>();

            foreach(Dier dier in beheerder.Dieren)
            {
                if (dier.Diernaam == diernaam)
                {
                    int diernummer = dier.Diernummer;
                    medicijnen = (List<Medicijn>)beheerder.MedicijnVanDier(diernummer);
                }
            }
            return medicijnen;
        }

        public List<Vaccinatie> ZoekVaccinaties(string dierverzogernaam)
        {
            // TODO zoek de datum van de vaccinatie op van de dierverzorger waarvan de naam overeenkomt met de naam die je meegeeft
            List<Vaccinatie> vaccinaties = (List<Vaccinatie>)beheerder.VaccinatiesDierverzorger(dierverzogernaam);
            return vaccinaties;
        }

        public Dierverzorger ZoekVerzorger(string dierverzorgernaam)
        {
            // TODO zoek alle info die bij de dierverzorger hoort waarvan de naam overeenkomt met de naam die je meegeeft
            foreach (Dierverzorger verzorger in beheerder.Dierverzorgers)
            {
                if (verzorger.Naam == dierverzorgernaam)
                {
                    return verzorger;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return Naam + Leeftijd + Wachtwoord + telefoonnummer;
        }
    }
}
