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

        #region Totaal aantal dieren op het park
        public int TotaalAantalDieren()
        {
            int dieren;
            dieren = this.db.DierenTotaal();
            return dieren;
        }
        #endregion

        #region Inloggen
        public Persoon Inloggen(string username, string wachtwoord)
        {
            Persoon p = (Persoon)this.db.Login(username, wachtwoord);
            return p;
        }
        #endregion

        #region Dier toevoegen
        public void VoegDierToe(Dier dier, int huisvestingnummer)
        {
            this.db.VoegDierToe(dier, huisvestingnummer);
        }
        #endregion

        #region Dier verwijderen
        public void VerwijderDier(int diernummer, string diernaam)
        {
            this.db.VerwijderDier(diernummer, diernaam);
        }
        #endregion

        #region Verblijf van dier opvragen
        public string VerblijfVanDier(int diernummer)
        {
            string verblijf = this.db.VerblijfDierOpvragen(diernummer);
            return verblijf;
        }
        #endregion

        #region Medicijn van dier opvragen
        public List<Medicijn> MedicijnVanDier(int diernummer)
        {
            List<Medicijn> medicijn = (List<Medicijn>)this.db.MedicijnDierOpvragen(diernummer);
           return medicijn;
        }
        #endregion

        #region Aantal dieren van het verblijf
        public int AantalDierenVeblijf(int huisvestingnummer)
        {
            int aantal = this.db.AantalDierenVerblijf(huisvestingnummer);
            return aantal;
        }
        #endregion

        #region Ras van dier opvragen
        public string RasVanDier(int diernummer)
        {
            string ras = this.db.RasDierOpvragen(diernummer);
            return ras;
        }
        #endregion

        #region Veelvoorkomende ziektes van diersoort
        public List<string> VeelVoorkomendeZiektesDiersoort(int diersoortnummer)
        {
            List<string> ziektes = this.db.VeelVoorkomendeZiektes(diersoortnummer);
            return ziektes;
        }

        #endregion

        #region Voeding van diersoort 
        public string VoedingDiersoort(int diersoortnummer)
        {
            string voeding = this.db.VoedingDiersoort(diersoortnummer);
            return voeding;
        }
        #endregion

        #region Huisvesting van diersoort opvragen
        public string HuisvestingDiersoort(int diersoortnummer)
        {
            string huisvesting = this.db.HuisvestingnaamDiersoort(diersoortnummer);
            return huisvesting;
        }
        #endregion

        #region Diersoort zoeken
        public Diersoort ZoekDiersoort(int diersoortnummer)
        {
            Diersoort diersoort = (Diersoort)this.db.ZoekDiersoort(diersoortnummer);
            return diersoort;
        }
        #endregion

        #region Diersoort zoeken en lijst vullen
        public List<Diersoort> ZoekDiersoortLijst()
        {
            List<Diersoort> diersoorten = (List<Diersoort>)this.db.ZoekDiersoorten();
            return diersoorten;
        }
        #endregion

        #region Info specifiek dier opvragen
        public Dier InfoDier(string diernaam)
        {
            Dier dier = (Dier)this.db.InfoDier(diernaam);
            return dier;
        }

        #endregion

        #region Begindatum van medicijn opvragen
        public DateTime MedicijnStartdatum(string diernaam)
        {
            DateTime startdatum = (DateTime)this.db.BeginMedicijn(diernaam);
            return startdatum;
        }
        #endregion

        #region Naam dierverzorgers opvragen
        public List<string> NaamDierverzorgers()
        {
            List<string> namen = this.db.NaamDierverzorgers();
            return namen;
        }

        #endregion

        #region Naam dierverzorger opvragen
        public string NaamDierverzorger(int dierverzorgernummer)
        {
            string naam = this.db.NaamDierverzorger(dierverzorgernummer);
            return naam;
        }

        #endregion

        #region Naam dierenarts opvragen
        public string NaamDierenarts(int dierenartsnummer)
        {
            string naam = this.db.NaamDierenarts(dierenartsnummer);
            return naam;
        }
        #endregion

        #region Telefoonnummer dierenarts opvragen
        public int TelefoonNrDierenarts(int dierenartsnummer)
        {
            int telefoonnummer = this.db.TelDierenarts(dierenartsnummer);
            return telefoonnummer;
        }

        #endregion

        #region Telefoonnummer dierenarts opvragen met naam
        public int TelefoonNrDierenarts(string dierenartsnaam)
        {
            int telefoon = this.db.TelefoonDierenarts(dierenartsnaam);
            return telefoon;
        }
        #endregion

        #region Telefoonnummer dierverzorger opvragen
        public int TelefoonNrDierverzorger(int dierverzorgernummer)
        {
            int telefoon = this.db.TelPriveDierverzorger(dierverzorgernummer);
            return telefoon;
        }
        #endregion

        #region Telefoonnummer dierverzoger opvragen met naam
        public int TelefoonNrDierverzorger(string dierverzorgernaam)
        {
            int telefoon = this.db.TelPriveDierverzorger(dierverzorgernaam);
            return telefoon;
        }
        #endregion

        #region Telefoonnummer zakelijk dierverzorger opvragen met naam
        public int TelefoonNrZakelijkDierverzorger(string dierverzorgernaam)
        {
            int telefoon = this.db.TelZakelijkDierverzorger(dierverzorgernaam);
            return telefoon;
        }
        #endregion

        #region Telefoonnummer zakelijk dierverzorger opvragen
        public int TelefoonNrZakelijkDierverzorger(int dierverzorgernummer)
        {
            int telefoon = this.db.TelZakelijkDierverzorger(dierverzorgernummer);
            return telefoon;
        }
        #endregion

        #region Rekeningnummer dierverzorger opvragen met naam
        public int RekeningNrDierverzorger(string dierverzorgernaam)
        {
            int rekeningnummer = this.db.RekNrDierverzorger(dierverzorgernaam);
            return rekeningnummer;
        }
        #endregion

        #region Rekeningnummer dierenarts opvragen met naam
        public int RekeningNrDierenarts(string dierenartsnaam)
        {
            int rekeningnummer = this.db.RekNrDierenarts(dierenartsnaam);
            return rekeningnummer;
        }
        #endregion

        #region Rekeningnummer dierverzorger opvragen met nummer
        public int RekeningNrDierverzorger(int dierverzorgernummer)
        {
            int rekeningnummer = this.db.RekeningnrDierverzorger(dierverzorgernummer);
            return rekeningnummer;
        }
        #endregion

        #region Rekeningnummer dierenarts opvragen met nummer
        public int RekeningNrDierenarts(int dierenartsnummer)
        {
            int rekeningnummer = this.db.RekeningnrDierenarts(dierenartsnummer);
            return rekeningnummer;
        }
        #endregion

        #region Werkingsduur vaccinatie opvragen met naam
        public string WerkingsduurVaccinatie(string vaccinatienaam)
        {
            string werkingsduur = this.db.WerkingsduurVaccinatie(vaccinatienaam);
            return werkingsduur;
        }
        #endregion

        #region Werkingsduur vaccinatie opvragen met dierverzorgernummer
        public string WerkingsduurVaccinatie(int dierverzorgernummer)
        {
            string werkingsduur = this.db.DuurVaccinatie(dierverzorgernummer);
            return werkingsduur;
        }
        #endregion

        #region Werkingsduur vaccinatie opvragen met dierverzorgernaam
        public string WerkingsduurVaccinatieVerzorger(string dierverzorgernaam)
        {
            string werkingsduur = this.db.WerkingsduurVaccinatieVerzorger(dierverzorgernaam);
            return werkingsduur;
        }
        #endregion

        #region Vaccinatie verlopen op met dierverzorgernummer
        public DateTime VaccinatieVerlopenOp(int dierverzorgernummer)
        {
            DateTime verlopen = (DateTime)this.db.VaccinatieVerlopenOp(dierverzorgernummer);
            return verlopen;
        }
        #endregion

        #region Vaccinatie verlopen op met dierverzorgernaam
        public DateTime VaccinatieVerlopenOp(string dierverzorgernaam)
        {
            DateTime datum = (DateTime)this.db.VaccinatieVerlopen(dierverzorgernaam);
            return datum;
        }
        #endregion

        #region Vaccinaties van dierverzoger opvragen
        public List<Vaccinatie> VaccinatieDierverzorger(int dierverzorgernummer)
        {
            List<Vaccinatie> vaccinaties = (List<Vaccinatie>)this.db.VaccinatiesDierverzorger(dierverzorgernummer);
            return vaccinaties;
        }
        #endregion

        #region Vaccinaties van dierverzorger opvragen met naam
        public List<Vaccinatie> VaccinatiesDierverzorger(string dierverzorgernaam)
        {
            List<Vaccinatie> vaccinaties = (List<Vaccinatie>)this.db.VaccinatiesDierverzorger(dierverzorgernaam);
            return vaccinaties;
        }
        #endregion

        #region Dierverzorger toevoegen
        public void VoegToe(Dierverzorger dierverzorger)
        {
            this.db.DierverzorgerToevoegen(dierverzorger);
        }
        #endregion

        #region Dierverzorger verwijderen
        public void Verwijder(int dierverzorgernummer)
        {
            this.db.VerwijderDierverzorger(dierverzorgernummer);
        }
        #endregion

        #region Dierenarts toevoegen
        public void VoegToe(Dierenarts dierenarts)
        {
            this.db.DierenartsToevoegen(dierenarts);
        }
        #endregion

        #region Dierenarts verwijderen
        public void VerwijderArts(int dierenartsnummer)
        {
            this.db.VerwijderDierenarts(dierenartsnummer);
        }
        #endregion

        #region Verblijf zoeken
        public Huisvesting ZoekHuisvesting(int diersoortnummer)
        {
            Huisvesting huisvesting = (Huisvesting)this.db.HuisvestingDiersoort(diersoortnummer);
            return huisvesting;
        }
        #endregion

        #region Diersoort toevoegen
        public void VoegToeDiersoort(Diersoort diersoort)
        {
            this.db.VoegDiersoortToe(diersoort);
        }
        #endregion

        #region Vaccinatiedatum toevoegen
        public void VoegToeVaccinatiedatum(int dierverzorgernummer, string vaccinatienaam, DateTime datumgevaccineerd, DateTime datumverlopen, string bijwerking)
        {
            this.db.VoegVaccinatiedatumToe(dierverzorgernummer, vaccinatienaam, datumgevaccineerd, datumverlopen, bijwerking);
        }
        #endregion

        #region Vaccinaties opvragen 
        public List<Vaccinatie> AlleVaccinaties()
        {
            List<Vaccinatie> vaccinaties = (List<Vaccinatie>)this.db.AlleVaccinaties();
            return vaccinaties;
        }
        #endregion

        #region Medicijnen opvragen
        public List<Medicijn> AlleMedicijnen()
        {
            List<Medicijn> medicijnen = (List<Medicijn>)this.db.AlleMedicijnen();
            return this.medicijnen;
        }
        #endregion

        #region Dieren opvragen
        public List<Dier> AlleDieren()
        {
            this.dieren = (List<Dier>)this.db.AlleDieren();
            return this.dieren;
        }
        #endregion

        #region Dierverzorgers opvragen
        public List<Dierverzorger> AlleVerzorgers()
        {
            this.dierverzorgers = (List<Dierverzorger>)this.db.AlleVerzorgers();
            return this.dierverzorgers;
        }
        #endregion

    }
}
