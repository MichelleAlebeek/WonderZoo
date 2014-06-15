//Klasse Administratie. Deze kan alles met betrekking tot het opvragen, aanpassen of toevoegen van informatie.

namespace Klassen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
   
    public class Administratie : Persoon
    {
        private int telefoonnummer;
        private List<Diersoort> diersoorten;
        private Beheer beheerder;
        private int leeftijd;

        public Administratie(int telefoonnummer, string naam, int leeftijd, string wachtwoord, string beroep)
            : base(naam, wachtwoord, beroep)
        {
            this.telefoonnummer = telefoonnummer;
            this.leeftijd = leeftijd;
            this.diersoorten = new List<Diersoort>();
            this.beheerder = new Beheer();
        }

        public List<Diersoort> Diersoorten
        {
            get { return new List<Diersoort>(this.diersoorten); }
        }

        public int Telefoonnummer
        {
            get { return this.telefoonnummer; }
            set { this.telefoonnummer = value; }
        }
        public int Leeftijd
        {
            get { return this.leeftijd; }
            set { this.leeftijd = value; }
        }

        /// <summary>
        /// Het totaal aantal dieren in de dierentuin opvragen.
        /// </summary>
        /// <returns>int aantal dieren</returns>
        public int AantalDieren()
        {
            // Todo het aantal dieren opvragen
            int aantal = this.beheerder.TotaalAantalDieren();
            return aantal;
        }

        /// <summary>
        /// Opzoeken tot wanneer een vaccinatie geldig is.
        /// </summary>
        /// <param name="dierverzorgernaam">naam van de dierverzorger</param>
        /// <returns>Datum tot wanneer de vaccinatie geldig is</returns>
        public DateTime GeldigTot(string dierverzorgernaam)
        {
            // TODO zoek op tot wanneer de vaccinatie geldig is
            DateTime geldigtot = this.beheerder.VaccinatieVerlopenOp(dierverzorgernaam);
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

        /// <summary>
        /// Een dierverzorger verwijderen
        /// </summary>
        /// <param name="dierverzorgernummer">het nummer van de dierverzorger</param>
        public void Verwijder(int dierverzorgernummer)
        {
            // TODO verwijder de dierverzorger waarvan de naam overeenkomt met de naam die je meegeeft
            this.beheerder.Verwijder(dierverzorgernummer);
        }

        /// <summary>
        /// Een dierenarts verwijderen
        /// </summary>
        /// <param name="dierenartsnummer">nummer van de dierenarts</param>
        public void VerwijderDierenarts(int dierenartsnummer)
        {
            // TODO verwijder de dierenarts waarvan de naam overeenkomt met de naam die je meegeeft
            this.beheerder.VerwijderArts(dierenartsnummer);
        }

        /// <summary>
        /// dierenarts toevoegen
        /// </summary>
        /// <param name="arts">een Dierenarts</param>
        public void VoegToe(Dierenarts arts)
        {
            // TODO voeg de dierenarts toe aan de applicatie
            this.beheerder.VoegToe(arts);
        }

        /// <summary>
        /// dierverzorger toevoegen
        /// </summary>
        /// <param name="verzorger">een dierverzorger</param>
        public void VoegToe(Dierverzorger verzorger)
        {
            // TODO voeg de dierverzorger toe aan de applicatie
            this.beheerder.VoegToe(verzorger);
        }

        /// <summary>
        /// een dier toevoegen
        /// </summary>
        /// <param name="dier">een dier</param>
        /// <param name="huisvestingnummer">huisvesting nummer waar het dier komt</param>
        public void VoegToe(Dier dier, int huisvestingnummer)
        {
            // TODO voeg het dier toe aan de applicatie
            this.beheerder.VoegDierToe(dier, huisvestingnummer);
        }

        /// <summary>
        /// diersoort toevoegen
        /// </summary>
        /// <param name="diersoort">een diersoort</param>
        public void VoegToe(Diersoort diersoort)
        {
            // TODO voeg de diersoort toe aan de applicatie
            this.beheerder.VoegToeDiersoort(diersoort);
        }

        /// <summary>
        /// vaccinatiedatum toevoegen
        /// </summary>
        /// <param name="dierverzorgernummer">nummer van de dierverzorger</param>
        /// <param name="vaccinatienaam">naam van de vaccinatie</param>
        /// <param name="datumgevaccineerd">datum waarop gevaccineerd is</param>
        /// <param name="datumverlopen">datum waarop de vaccinatie verlopen is</param>
        /// <param name="bijwerking">eventuele bijwerkingen van de vaccinatie</param>
        public void VoegToeVaccinatiedatum (int dierverzorgernummer, string vaccinatienaam, DateTime datumgevaccineerd, DateTime datumverlopen, string bijwerking)
        {
            // TODO voeg de vaccinatiedatum toe aan de dierverzorger waarvan de naam overeenkomt met de naam die je meegeeft
            this.beheerder.VoegToeVaccinatiedatum(dierverzorgernummer, vaccinatienaam, datumgevaccineerd, datumverlopen, bijwerking);
        }

        /// <summary>
        /// werkingsduur van de vaccinatie opvragen
        /// </summary>
        /// <param name="dierverzorgernummer">nummer van dierverzorger</param>
        /// <returns>de werkingsduur van de vaccinatie</returns>
        public string WerkingsduurVaccinatieOpvragen(int dierverzorgernummer)
        {
            // TODO vraag de werkingsduur van de vaccinatie op waarvan de naam van de dierverzorger overeenkomt met de naam je meegeeft
            string werkingsduur = this.beheerder.WerkingsduurVaccinatie(dierverzorgernummer);
            return werkingsduur;
        }

        /// <summary>
        /// zoek alle informatie van dierenarts
        /// </summary>
        /// <param name="dierenartsnaam">naam van dierenarts</param>
        /// <returns>een dierenarts</returns>
        public Dierenarts ZoekArts(string dierenartsnaam)
        {
            // TODO geef alle informatie van de dierenarts terug waarvan de naam overeenkomt met de naam die je meegeeft
            foreach(Dierenarts arts in this.beheerder.Dierenartsen)
            {
                if(arts.Naam == dierenartsnaam)
                {
                    return arts;
                }
            }
            return null;
        }

        /// <summary>
        /// zoek alle info van een dier
        /// </summary>
        /// <param name="diernaam">naam van het dier</param>
        /// <returns>een dier</returns>
        public Dier ZoekDier(string diernaam)
        {
            // TODO geef alle informatie van het dier terug waarvan de naam overeenkomt met de naam die je meegeeft
            foreach (Dier dier in this.beheerder.Dieren)
            {
                if (dier.Diernaam == diernaam)
                {
                    return dier;
                }
            }
            return null;
        }

        /// <summary>
        /// Zoek een Diersoort
        /// </summary>
        /// <param name="geslacht">Familie naam (bijvoorbeeld Kangoeroes)</param>
        /// <returns>Een Diersoort</returns>
        public Diersoort ZoekDiersoort(string familie)
        {
            // TODO geef alle informatie van de diersoort terug waarvan het geslacht overeenkomt met het geslacht dat je meegeeft
            foreach (Diersoort diersoort in this.beheerder.Diersoorten)
            {
                if (diersoort.Familie == familie)
                {
                    int diersoortnummer = diersoort.Diersoortnummer;
                    Diersoort diersoortje = this.beheerder.ZoekDiersoort(diersoortnummer);
                    return diersoortje;
                }
            }        
            return null;
        }

        /// <summary>
        /// zoek medicijnen van een dier
        /// </summary>
        /// <param name="diernaam">naam van het Dier</param>
        /// <returns>een lijst van medicijnen</returns>
        public List<Medicijn> ZoekMedicijn(string diernaam)
        {
            // TODO zoek het medicijn die bij het dier met het meegegeven diernaam hoort
            List<Medicijn> medicijnen = new List<Medicijn>();

            foreach(Dier dier in this.beheerder.Dieren)
            {
                if (dier.Diernaam == diernaam)
                {
                    int diernummer = dier.Diernummer;
                    medicijnen = (List<Medicijn>)this.beheerder.MedicijnVanDier(diernummer);
                }
            }
            return medicijnen;
        }

        /// <summary>
        /// zoek de vaccinaties van een dierverzorger
        /// </summary>
        /// <param name="dierverzogernaam">naam van dierverzorger</param>
        /// <returns>lijst van vaccinaties</returns>
        public List<Vaccinatie> ZoekVaccinaties(string dierverzogernaam)
        {
            // TODO zoek de datum van de vaccinatie op van de dierverzorger waarvan de naam overeenkomt met de naam die je meegeeft
            List<Vaccinatie> vaccinaties = (List<Vaccinatie>)this.beheerder.VaccinatiesDierverzorger(dierverzogernaam);
            return vaccinaties;
        }

        /// <summary>
        /// zoek alle info van een dierverzorger
        /// </summary>
        /// <param name="dierverzorgernaam">naam van dierverzorger</param>
        /// <returns>een dierverzorger</returns>
        public Dierverzorger ZoekVerzorger(string dierverzorgernaam)
        {
            // TODO zoek alle info die bij de dierverzorger hoort waarvan de naam overeenkomt met de naam die je meegeeft
            foreach (Dierverzorger verzorger in this.beheerder.Dierverzorgers)
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
            return this.Naam + this.Wachtwoord + this.telefoonnummer;
        }
    }
}
