//Klassen beheer (dit is een facade klassen)
using Databasekoppeling; //als ik deze in de namespace plaats dan kent het programma de database koppeling niet meer. Vandaar warning SA1200 bij StyleCop.

namespace Klassen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Klassen.Properties;
 
    public class Beheer
    {
        private Databasekoppeling.Databasekoppeling db;
        private List<Dier> dieren;
        private List<Huisvesting> huisvestings;
        private List<Ras> rassen;
        private List<Medicijn> medicijnen;
        private List<Persoon> personen;
        private List<Dierenarts> dierenartsen;
        private List<Diersoort> diersoorten;
        private List<Dierverzorger> dierverzorgers;
        private List<Vaccinatie> vaccinaties;
        public Beheer()
        {
            this.db = new Databasekoppeling.Databasekoppeling();
            this.dieren = new List<Dier>();
            this.huisvestings = new List<Huisvesting>();
            this.rassen = new List<Ras>();
            this.medicijnen = new List<Medicijn>();
            this.personen = new List<Persoon>();
            this.dierenartsen = new List<Dierenarts>();
            this.diersoorten = new List<Diersoort>();
            this.dierverzorgers = new List<Dierverzorger>();
            this.vaccinaties = new List<Vaccinatie>();
        }

        public List<Dier> Dieren
        {
            get { return new List<Dier>(this.dieren); }
        }
        public List<Vaccinatie> Vaccinaties
        {
            get { return new List<Vaccinatie>(this.vaccinaties); }
        }
        public List<Huisvesting> Huisvestings
        {
            get { return new List<Huisvesting>(this.huisvestings); }
        }

        public List<Ras> Rassen
        {
            get { return new List<Ras>(this.rassen); }
        }

        public List<Medicijn> Medicijnen
        {
            get { return new List<Medicijn>(this.medicijnen); }
        }

        public List<Persoon> Personen
        {
            get { return new List<Persoon>(this.personen); }
        }

        public List<Dierenarts> Dierenartsen
        {
            get { return new List<Dierenarts>(this.dierenartsen); }
        }

        public List<Diersoort> Diersoorten
        {
            get { return new List<Diersoort>(this.diersoorten); }
        }

        public List<Dierverzorger> Dierverzorgers
        {
            get { return new List<Dierverzorger>(this.dierverzorgers); }
        }

        /// <summary>
        /// het totaal aantal dieren op het park
        /// </summary>
        /// <returns>het aantal dieren</returns>
        #region Totaal aantal dieren op het park
        public int TotaalAantalDieren()
        {
            int dieren;
            dieren = this.db.DierenTotaal();
            return dieren;
        }
        #endregion

        /// <summary>
        /// inloggen van gebruiker
        /// </summary>
        /// <param name="username">gebruikersnaam van gebruiker</param>
        /// <param name="wachtwoord">wachtwoord van gebruiker</param>
        /// <returns>de gebruiker die inlogt</returns>
        #region Inloggen
        public Persoon Inloggen(string username, string wachtwoord)
        {
            Persoon p = (Persoon)this.db.Login(username, wachtwoord);
            return p;
        }
        #endregion

        /// <summary>
        /// een dier toevoegen
        /// </summary>
        /// <param name="dier">een dier</param>
        /// <param name="huisvestingnummer">nummer van de huisvesting waar het dier komt</param>
        #region Dier toevoegen
        public void VoegDierToe(Dier dier, int huisvestingnummer)
        {
            this.db.VoegDierToe(dier, huisvestingnummer);
        }
        #endregion

        /// <summary>
        /// dier verwijderen
        /// </summary>
        /// <param name="diernummer">nummer van het dier</param>
        /// <param name="diernaam">naam van het dier</param>
        #region Dier verwijderen
        public void VerwijderDier(int diernummer, string diernaam)
        {
            this.db.VerwijderDier(diernummer, diernaam);
        }
        #endregion

        /// <summary>
        /// verblijf van het dier opvragen
        /// </summary>
        /// <param name="diernummer">nummer van het dier</param>
        /// <returns>het nummer en de naam van het verblijf</returns>
        #region Verblijf van dier opvragen
        public string VerblijfVanDier(int diernummer)
        {
            string verblijf = this.db.VerblijfDierOpvragen(diernummer);
            return verblijf;
        }
        #endregion

        /// <summary>
        /// medicijnen van dier opvragen
        /// </summary>
        /// <param name="diernummer">nummer van dier</param>
        /// <returns>een lijst van medicijnen</returns>
        #region Medicijn van dier opvragen
        public List<Medicijn> MedicijnVanDier(int diernummer)
        {
            List<Medicijn> medicijn = (List<Medicijn>)this.db.MedicijnDierOpvragen(diernummer);
           return medicijn;
        }
        #endregion

        /// <summary>
        /// aantal dieren in een verblijf opvragen
        /// </summary>
        /// <param name="huisvestingnummer">nummer van het verblijf</param>
        /// <returns>het aantal dieren in het verblijf</returns>
        #region Aantal dieren van het verblijf
        public int AantalDierenVeblijf(int huisvestingnummer)
        {
            int aantal = this.db.AantalDierenVerblijf(huisvestingnummer);
            return aantal;
        }
        #endregion

        /// <summary>
        /// ras van het dier opvragen
        /// </summary>
        /// <param name="diernummer">nummer van het dier</param>
        /// <returns>naam van het ras</returns>
        #region Ras van dier opvragen
        public string RasVanDier(int diernummer)
        {
            string ras = this.db.RasDierOpvragen(diernummer);
            return ras;
        }
        #endregion

        /// <summary>
        /// veel voorkomende ziektes van een diersoort opvragen
        /// </summary>
        /// <param name="diersoortnummer">nummer van diersoort</param>
        /// <returns>een lijst van strings met de ziektes</returns>
        #region Veelvoorkomende ziektes van diersoort
        public List<string> VeelVoorkomendeZiektesDiersoort(int diersoortnummer)
        {
            List<string> ziektes = this.db.VeelVoorkomendeZiektes(diersoortnummer);
            return ziektes;
        }
        #endregion

        /// <summary>
        /// voeding van het diersoort opvragen
        /// </summary>
        /// <param name="diersoortnummer">nummer van het diersoort</param>
        /// <returns>de naam van de voeding</returns>
        #region Voeding van diersoort 
        public string VoedingDiersoort(int diersoortnummer)
        {
            string voeding = this.db.VoedingDiersoort(diersoortnummer);
            return voeding;
        }
        #endregion

        /// <summary>
        /// huisvesting van diersoort opvragen
        /// </summary>
        /// <param name="diersoortnummer">nummer van het diersoort</param>
        /// <returns>naam van de huisvesting</returns>
        #region Huisvesting van diersoort opvragen
        public string HuisvestingDiersoort(int diersoortnummer)
        {
            string huisvesting = this.db.HuisvestingnaamDiersoort(diersoortnummer);
            return huisvesting;
        }
        #endregion

        /// <summary>
        /// een diersoort zoeken
        /// </summary>
        /// <param name="diersoortnummer">nummer van het diersoort</param>
        /// <returns>een diersoort</returns>
        #region Diersoort zoeken
        public Diersoort ZoekDiersoort(int diersoortnummer)
        {
            Diersoort diersoort = (Diersoort)this.db.ZoekDiersoort(diersoortnummer);
            return diersoort;
        }
        #endregion

        /// <summary>
        /// lijst van diersoorten vullen
        /// </summary>
        /// <returns>lijst van diersoorten</returns>
        #region Diersoort zoeken en lijst vullen
        public List<Diersoort> ZoekDiersoortLijst()
        {
            List<Diersoort> diersoorten = (List<Diersoort>)this.db.ZoekDiersoorten();
            return diersoorten;
        }
        #endregion

        /// <summary>
        /// info van een specifiek dier opvragen
        /// </summary>
        /// <param name="diernaam">naam van het dier</param>
        /// <returns>een dier</returns>
        #region Info specifiek dier opvragen
        public Dier InfoDier(string diernaam)
        {
            Dier dier = (Dier)this.db.InfoDier(diernaam);
            return dier;
        }
        #endregion

        /// <summary>
        /// begin datum van het medicijn opvragen
        /// </summary>
        /// <param name="diernaam">naam van het dier</param>
        /// <returns>begin datum</returns>
        #region Begindatum van medicijn opvragen
        public DateTime MedicijnStartdatum(string diernaam)
        {
            DateTime startdatum = (DateTime)this.db.BeginMedicijn(diernaam);
            return startdatum;
        }
        #endregion

        /// <summary>
        /// Naam dierverzorgers opvragen
        /// </summary>
        /// <returns>een lijst van dierverzorgers namen</returns>
        #region Naam dierverzorgers opvragen
        public List<string> NaamDierverzorgers()
        {
            List<string> namen = this.db.NaamDierverzorgers();
            return namen;
        }
        #endregion

        /// <summary>
        /// naam van een dierverzorger opvragen
        /// </summary>
        /// <param name="dierverzorgernummer">nummer van dierverzorger</param>
        /// <returns>de naam van de dierverzorger</returns>
        #region Naam dierverzorger opvragen
        public string NaamDierverzorger(int dierverzorgernummer)
        {
            string naam = this.db.NaamDierverzorger(dierverzorgernummer);
            return naam;
        }
        #endregion
        
        /// <summary>
        /// naam van dierenarts opvragen
        /// </summary>
        /// <param name="dierenartsnummer">nummer van dierenarts</param>
        /// <returns>naam van de dierenarts</returns>
        #region Naam dierenarts opvragen
        public string NaamDierenarts(int dierenartsnummer)
        {
            string naam = this.db.NaamDierenarts(dierenartsnummer);
            return naam;
        }
        #endregion

        /// <summary>
        /// telefoonnummer van dierenarts opvragen
        /// </summary>
        /// <param name="dierenartsnummer">nummer van dierenarts</param>
        /// <returns>telefoon nummer</returns>
        #region Telefoonnummer dierenarts opvragen
        public int TelefoonNrDierenarts(int dierenartsnummer)
        {
            int telefoonnummer = this.db.TelDierenarts(dierenartsnummer);
            return telefoonnummer;
        }
        #endregion
        
        /// <summary>
        /// telefoonnummer van dierenarts opvragen met naam
        /// </summary>
        /// <param name="dierenartsnaam">naam van dierenarts</param>
        /// <returns>telefoon nummer</returns>
        #region Telefoonnummer dierenarts opvragen met naam
        public int TelefoonNrDierenarts(string dierenartsnaam)
        {
            int telefoon = this.db.TelefoonDierenarts(dierenartsnaam);
            return telefoon;
        }
        #endregion

        /// <summary>
        /// telefoonnummer van dierverzorger opvragen
        /// </summary>
        /// <param name="dierverzorgernummer">nummer van dierverzorger</param>
        /// <returns>telefoon nummer</returns>
        #region Telefoonnummer dierverzorger opvragen
        public int TelefoonNrDierverzorger(int dierverzorgernummer)
        {
            int telefoon = this.db.TelPriveDierverzorger(dierverzorgernummer);
            return telefoon;
        }
        #endregion

        /// <summary>
        /// telefoonnummer van dierverzorger opvragen met naam
        /// </summary>
        /// <param name="dierverzorgernaam">naam dierverzorger</param>
        /// <returns>telefoon nummer</returns>
        #region Telefoonnummer dierverzoger opvragen met naam
        public int TelefoonNrDierverzorger(string dierverzorgernaam)
        {
            int telefoon = this.db.TelPriveDierverzorger(dierverzorgernaam);
            return telefoon;
        }
        #endregion

        /// <summary>
        /// telefoonnummer zakelijk van dierverzorger opvragen
        /// </summary>
        /// <param name="dierverzorgernaam">naam van dierverzorger</param>
        /// <returns>telefoonnummer zakelijk</returns>
        #region Telefoonnummer zakelijk dierverzorger opvragen met naam
        public int TelefoonNrZakelijkDierverzorger(string dierverzorgernaam)
        {
            int telefoon = this.db.TelZakelijkDierverzorger(dierverzorgernaam);
            return telefoon;
        }
        #endregion

        /// <summary>
        /// telefoonnummer zakelijk van dierverzorger opvragen
        /// </summary>
        /// <param name="dierverzorgernummer">nummer van dierverzorger</param>
        /// <returns>telefoonnummer zakelijk</returns>
        #region Telefoonnummer zakelijk dierverzorger opvragen
        public int TelefoonNrZakelijkDierverzorger(int dierverzorgernummer)
        {
            int telefoon = this.db.TelZakelijkDierverzorger(dierverzorgernummer);
            return telefoon;
        }
        #endregion

        /// <summary>
        /// rekeningnnummer van dierverzorger opvragen met naam
        /// </summary>
        /// <param name="dierverzorgernaam">naam dierverzorger</param>
        /// <returns>rekening nummer</returns>
        #region Rekeningnummer dierverzorger opvragen met naam
        public int RekeningNrDierverzorger(string dierverzorgernaam)
        {
            int rekeningnummer = this.db.RekNrDierverzorger(dierverzorgernaam);
            return rekeningnummer;
        }
        #endregion

        /// <summary>
        /// rekeningnummer dierenarts opvragen met naam
        /// </summary>
        /// <param name="dierenartsnaam">naam dierenarts</param>
        /// <returns>rekening nummer</returns>
        #region Rekeningnummer dierenarts opvragen met naam
        public int RekeningNrDierenarts(string dierenartsnaam)
        {
            int rekeningnummer = this.db.RekNrDierenarts(dierenartsnaam);
            return rekeningnummer;
        }
        #endregion

        /// <summary>
        /// rekeningnummer dierverzorger opvragen met nummer
        /// </summary>
        /// <param name="dierverzorgernummer">nummer dierverzorger</param>
        /// <returns>rekening nummer</returns>
        #region Rekeningnummer dierverzorger opvragen met nummer
        public int RekeningNrDierverzorger(int dierverzorgernummer)
        {
            int rekeningnummer = this.db.RekeningnrDierverzorger(dierverzorgernummer);
            return rekeningnummer;
        }
        #endregion

        /// <summary>
        /// rekeningnummer dierenarts opvragen met nummer
        /// </summary>
        /// <param name="dierenartsnummer">nummer dierenarts</param>
        /// <returns>rekening nummer</returns>
        #region Rekeningnummer dierenarts opvragen met nummer
        public int RekeningNrDierenarts(int dierenartsnummer)
        {
            int rekeningnummer = this.db.RekeningnrDierenarts(dierenartsnummer);
            return rekeningnummer;
        }
        #endregion

        /// <summary>
        /// werkingsduur van vaccinatie opvragen
        /// </summary>
        /// <param name="vaccinatienaam">naam van de vaccinatie</param>
        /// <returns>werkingsduur van vaccinatie</returns>
        #region Werkingsduur vaccinatie opvragen met naam
        public string WerkingsduurVaccinatie(string vaccinatienaam)
        {
            string werkingsduur = this.db.WerkingsduurVaccinatie(vaccinatienaam);
            return werkingsduur;
        }
        #endregion

        /// <summary>
        /// werkingsduur vaccinatie van dierverzorger opvragen 
        /// </summary>
        /// <param name="dierverzorgernummer">nummer van dierverzorger</param>
        /// <returns>werkingsduur van vaccinatie</returns>
        #region Werkingsduur vaccinatie opvragen met dierverzorgernummer
        public string WerkingsduurVaccinatie(int dierverzorgernummer)
        {
            string werkingsduur = this.db.DuurVaccinatie(dierverzorgernummer);
            return werkingsduur;
        }
        #endregion

        /// <summary>
        /// werkingsduur van vaccinatie van dierverzorger opvragen
        /// </summary>
        /// <param name="dierverzorgernaam">naam dierverzorger</param>
        /// <returns>werkingsduur van vaccinatie</returns>
        #region Werkingsduur vaccinatie opvragen met dierverzorgernaam
        public string WerkingsduurVaccinatieVerzorger(string dierverzorgernaam)
        {
            string werkingsduur = this.db.WerkingsduurVaccinatieVerzorger(dierverzorgernaam);
            return werkingsduur;
        }
        #endregion

        /// <summary>
        /// vaccinatie verlopen van dierverzorger
        /// </summary>
        /// <param name="dierverzorgernummer">nummer van dierverzorger</param>
        /// <returns>datum waarop vaccinatie is verlopen</returns>
        #region Vaccinatie verlopen op met dierverzorgernummer
        public DateTime VaccinatieVerlopenOp(int dierverzorgernummer)
        {
            DateTime verlopen = (DateTime)this.db.VaccinatieVerlopenOp(dierverzorgernummer);
            return verlopen;
        }
        #endregion

        /// <summary>
        /// vaccinatie verlopen van dierverzorger
        /// </summary>
        /// <param name="dierverzorgernaam">naam dierverzorger</param>
        /// <returns>datum waarom de vaccinatie is verlopen</returns>
        #region Vaccinatie verlopen op met dierverzorgernaam
        public DateTime VaccinatieVerlopenOp(string dierverzorgernaam)
        {
            DateTime datum = (DateTime)this.db.VaccinatieVerlopen(dierverzorgernaam);
            return datum;
        }
        #endregion

        /// <summary>
        /// vaccinaties van dierverzorger opvragen
        /// </summary>
        /// <param name="dierverzorgernummer">nummer van dierverzorger</param>
        /// <returns>lijst met vaccinaties van dierverzorger</returns>
        #region Vaccinaties van dierverzoger opvragen
        public List<Vaccinatie> VaccinatieDierverzorger(int dierverzorgernummer)
        {
            List<Vaccinatie> vaccinaties = (List<Vaccinatie>)this.db.VaccinatiesDierverzorger(dierverzorgernummer);
            return vaccinaties;
        }
        #endregion

        /// <summary>
        /// vaccinaties van dierverzorger opvragen
        /// </summary>
        /// <param name="dierverzorgernaam">naam dierverzorger</param>
        /// <returns>een lijst van vaccinaties van dierverzorger</returns>
        #region Vaccinaties van dierverzorger opvragen met naam
        public List<Vaccinatie> VaccinatiesDierverzorger(string dierverzorgernaam)
        {
            List<Vaccinatie> vaccinaties = (List<Vaccinatie>)this.db.VaccinatiesDierverzorger(dierverzorgernaam);
            return vaccinaties;
        }
        #endregion

        /// <summary>
        /// een dierverzorger toevoegen
        /// </summary>
        /// <param name="dierverzorger">een dierverzorger</param>
        #region Dierverzorger toevoegen
        public void VoegToe(Dierverzorger dierverzorger)
        {
            this.db.DierverzorgerToevoegen(dierverzorger);
        }
        #endregion

        /// <summary>
        /// een dierverzorger verwijderen
        /// </summary>
        /// <param name="dierverzorgernummer">nummer van dierverzorger</param>
        #region Dierverzorger verwijderen
        public void Verwijder(int dierverzorgernummer)
        {
            this.db.VerwijderDierverzorger(dierverzorgernummer);
        }
        #endregion

        /// <summary>
        /// dierenarts toevoegen
        /// </summary>
        /// <param name="dierenarts">een dierenarts</param>
        #region Dierenarts toevoegen
        public void VoegToe(Dierenarts dierenarts)
        {
            this.db.DierenartsToevoegen(dierenarts);
        }
        #endregion

        /// <summary>
        /// dierenarts verwijderen
        /// </summary>
        /// <param name="dierenartsnummer">nummer van dierenarts</param>
        #region Dierenarts verwijderen
        public void VerwijderArts(int dierenartsnummer)
        {
            this.db.VerwijderDierenarts(dierenartsnummer);
        }
        #endregion

        /// <summary>
        /// verblijf van een diersoort zoeken
        /// </summary>
        /// <param name="diersoortnummer">nummer van diersoort</param>
        /// <returns>het verblijf</returns>
        #region Verblijf zoeken
        public Huisvesting ZoekHuisvesting(int diersoortnummer)
        {
            Huisvesting huisvesting = (Huisvesting)this.db.HuisvestingDiersoort(diersoortnummer);
            return huisvesting;
        }
        #endregion

        /// <summary>
        /// diersoort toevoegen
        /// </summary>
        /// <param name="diersoort">Diersoort</param>
        #region Diersoort toevoegen
        public void VoegToeDiersoort(Diersoort diersoort)
        {
            this.db.VoegDiersoortToe(diersoort);
        }
        #endregion

        /// <summary>
        /// vaccinatie toevoegen
        /// </summary>
        /// <param name="dierverzorgernummer">nummer dierverzorger</param>
        /// <param name="vaccinatienaam">naam van de vaccinatie</param>
        /// <param name="datumgevaccineerd">datum waarop vaccinatie is gegeven</param>
        /// <param name="datumverlopen">datum waarop vaccinatie is verlopen</param>
        /// <param name="bijwerking">eventuele bijwerkingen</param>
        #region Vaccinatiedatum toevoegen
        public void VoegToeVaccinatiedatum(int dierverzorgernummer, string vaccinatienaam, DateTime datumgevaccineerd, DateTime datumverlopen, string bijwerking)
        {
            this.db.VoegVaccinatiedatumToe(dierverzorgernummer, vaccinatienaam, datumgevaccineerd, datumverlopen, bijwerking);
        }
        #endregion

        /// <summary>
        /// alle vaccinaties opvragen 
        /// </summary>
        /// <returns>een lijst van alle vaccinaties</returns>
        #region Vaccinaties opvragen 
        public List<Vaccinatie> AlleVaccinaties()
        {
            List<Vaccinatie> vaccinaties = (List<Vaccinatie>)this.db.AlleVaccinaties();
            return vaccinaties;
        }
        #endregion

        /// <summary>
        /// alle medicijnen opvragen
        /// </summary>
        /// <returns>een lijst van alle medicijnen</returns>
        #region Medicijnen opvragen
        public List<Medicijn> AlleMedicijnen()
        {
            List<Medicijn> medicijnen = (List<Medicijn>)this.db.AlleMedicijnen();
            return this.medicijnen;
        }
        #endregion

        /// <summary>
        /// alle dieren opvragen
        /// </summary>
        /// <returns>een lijst van dieren</returns>
        #region Dieren opvragen
        public List<Dier> AlleDieren()
        {
            this.dieren = (List<Dier>)this.db.AlleDieren();
            return this.dieren;
        }
        #endregion

        /// <summary>
        /// alle dierverzorgers opvragen
        /// </summary>
        /// <returns>een lijst van alle dierverzorgers</returns>
        #region Dierverzorgers opvragen
        public List<Dierverzorger> AlleVerzorgers()
        {
            this.dierverzorgers = (List<Dierverzorger>)this.db.AlleVerzorgers();
            return this.dierverzorgers;
        }
        #endregion

    }
}
