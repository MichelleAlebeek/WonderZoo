using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klassen.Properties;
using Databasekoppeling;

namespace Klassen
{
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
        public Beheer()
        {
            db = new Databasekoppeling.Databasekoppeling();
            dieren = new List<Dier>();
            huisvestings = new List<Huisvesting>();
            rassen = new List<Ras>();
            medicijnen = new List<Medicijn>();
            personen = new List<Persoon>();
            dierenartsen = new List<Dierenarts>();
            diersoorten = new List<Diersoort>();
            dierverzorgers = new List<Dierverzorger>();
        }

        public List<Dier> Dieren
        {
            get { return new List<Dier>(dieren); }
        }
        public List<Huisvesting> Huisvestings
        {
            get { return new List<Huisvesting>(huisvestings); }
        }

        public List<Ras> Rassen
        {
            get { return new List<Ras>(rassen); }
        }

        public List<Medicijn> Medicijnen
        {
            get { return new List<Medicijn>(medicijnen); }
        }

        public List<Persoon> Personen
        {
            get { return new List<Persoon>(personen); }
        }

        public List<Dierenarts> Dierenartsen
        {
            get { return new List<Dierenarts>(dierenartsen); }
        }

        public List<Diersoort> Diersoorten
        {
            get { return new List<Diersoort>(diersoorten); }
        }

        public List<Dierverzorger> Dierverzorgers
        {
            get { return new List<Dierverzorger>(dierverzorgers); }
        }

        #region Totaal aantal dieren op het park
        public int TotaalAantalDieren()
        {
            int dieren;
            dieren = db.DierenTotaal();
            return dieren;
        }
        #endregion

        #region Inloggen
        public Persoon Inloggen(string username, string wachtwoord)
        {
            Persoon p = (Persoon)db.Login(username, wachtwoord);
            return p;
        }
        #endregion

        #region Dier toevoegen
        public void VoegDierToe(Dier dier)
        {
            db.VoegDierToe(dier);
        }
        #endregion

        #region Dier verwijderen
        public void VerwijderDier(int diernummer, string diernaam)
        {
            db.VerwijderDier(diernummer, diernaam);
        }
        #endregion

        #region Verblijf van dier opvragen
        public string VerblijfVanDier(int diernummer)
        {
            string verblijf = db.VerblijfDierOpvragen(diernummer);
            return verblijf;
        }
        #endregion

        #region Medicijn van dier opvragen
        public List<Medicijn> MedicijnVanDier(int diernummer)
        {
           List<Medicijn> medicijn = (List<Medicijn>)db.MedicijnDierOpvragen(diernummer);
           return medicijn;
        }
        #endregion

        #region Aantal dieren van het verblijf
        public int AantalDierenVeblijf(int huisvestingnummer)
        {
            int aantal = db.AantalDierenVerblijf(huisvestingnummer);
            return aantal;
        }
        #endregion

        #region Ras van dier opvragen
        public string RasVanDier(int diernummer)
        {
            string ras = db.RasDierOpvragen(diernummer);
            return ras;
        }
        #endregion

        #region Veelvoorkomende ziektes van diersoort
        public string VeelVoorkomendeZiektesDiersoort(int diersoortnummer)
        {
            string ziektes = db.VeelVoorkomendeZiektes(diersoortnummer);
            return ziektes;
        }

        #endregion

        #region Voeding van diersoort 
        public string VoedingDiersoort(int diersoortnummer)
        {
            string voeding = db.VoedingDiersoort(diersoortnummer);
            return voeding;
        }
        #endregion

        #region Huisvesting van diersoort opvragen
        public string HuisvestingDiersoort(int diersoortnummer)
        {
            string huisvesting = db.HuisvestingnaamDiersoort(diersoortnummer);
            return huisvesting;
        }
        #endregion

        #region Diersoort zoeken
        public Diersoort ZoekDiersoort(int diersoortnummer)
        {
            Diersoort diersoort = (Diersoort)db.ZoekDiersoort(diersoortnummer);
            return diersoort;
        }
        #endregion

        #region Diersoort zoeken en lijst vullen
        public List<Diersoort> ZoekDiersoortLijst()
        {
            List<Diersoort> diersoorten = (List<Diersoort>)db.ZoekDiersoorten();
            return diersoorten;
        }
        #endregion

        #region Info specifiek dier opvragen
        public Dier InfoDier(string diernaam)
        {
            Dier dier = (Dier)db.InfoDier(diernaam);
            return dier;
        }

        #endregion

        #region Begindatum van medicijn opvragen
        public DateTime MedicijnStartdatum(string diernaam)
        {
            DateTime startdatum = (DateTime)db.BeginMedicijn(diernaam);
            return startdatum;
        }
        #endregion

        #region Naam dierverzorgers opvragen
        public List<String> NaamDierverzorgers()
        {
            List<String> namen = db.NaamDierverzorgers();
            return namen;
        }

        #endregion

        #region Naam dierverzorger opvragen
        public string NaamDierverzorger(int dierverzorgernummer)
        {
            string naam = db.NaamDierverzorger(dierverzorgernummer);
            return naam;
        }

        #endregion

        #region Naam dierenarts opvragen
        public string NaamDierenarts(int dierenartsnummer)
        {
            string naam = db.NaamDierenarts(dierenartsnummer);
            return naam;
        }
        #endregion

        #region Telefoonnummer dierenarts opvragen
        public int TelefoonNrDierenarts(int dierenartsnummer)
        {
            int telefoonnummer = db.TelDierenarts(dierenartsnummer);
            return telefoonnummer;
        }

        #endregion

        #region Telefoonnummer dierenarts opvragen met naam
        public int TelefoonNrDierenarts(string dierenartsnaam)
        {
            int telefoon = db.TelefoonDierenarts(dierenartsnaam);
            return telefoon;
        }
        #endregion

        #region Telefoonnummer dierverzorger opvragen
        public int TelefoonNrDierverzorger(int dierverzorgernummer)
        {
            int telefoon = db.TelPriveDierverzorger(dierverzorgernummer);
            return telefoon;
        }
        #endregion

        #region Telefoonnummer dierverzoger opvragen met naam
        public int TelefoonNrDierverzorger(string dierverzorgernaam)
        {
            int telefoon = db.TelPriveDierverzorger(dierverzorgernaam);
            return telefoon;
        }
        #endregion

        #region Telefoonnummer zakelijk dierverzorger opvragen met naam
        public int TelefoonNrZakelijkDierverzorger(string dierverzorgernaam)
        {
            int telefoon = db.TelZakelijkDierverzorger(dierverzorgernaam);
            return telefoon;
        }
        #endregion

        #region Telefoonnummer zakelijk dierverzorger opvragen
        public int TelefoonNrZakelijkDierverzorger(int dierverzorgernummer)
        {
            int telefoon = db.TelZakelijkDierverzorger(dierverzorgernummer);
            return telefoon;
        }
        #endregion

        #region Rekeningnummer dierverzorger opvragen met naam
        public int RekeningNrDierverzorger(string dierverzorgernaam)
        {
            int rekeningnummer = db.RekNrDierverzorger(dierverzorgernaam);
            return rekeningnummer;
        }
        #endregion

        #region Rekeningnummer dierenarts opvragen met naam
        public int RekeningNrDierenarts(string dierenartsnaam)
        {
            int rekeningnummer = db.RekNrDierenarts(dierenartsnaam);
            return rekeningnummer;
        }
        #endregion

        #region Rekeningnummer dierverzorger opvragen met nummer
        public int RekeningNrDierverzorger(int dierverzorgernummer)
        {
            int rekeningnummer = db.RekeningnrDierverzorger(dierverzorgernummer);
            return rekeningnummer;
        }
        #endregion

        #region Rekeningnummer dierenarts opvragen met nummer
        public int RekeningNrDierenarts(int dierenartsnummer)
        {
            int rekeningnummer = db.RekeningnrDierenarts(dierenartsnummer);
            return rekeningnummer;
        }
        #endregion

        #region Werkingsduur vaccinatie opvragen met naam
        public string WerkingsduurVaccinatie(string vaccinatienaam)
        {
            string werkingsduur = db.WerkingsduurVaccinatie(vaccinatienaam);
            return werkingsduur;
        }
        #endregion

        #region Werkingsduur vaccinatie opvragen met dierverzorgernummer
        public string WerkingsduurVaccinatie(int dierverzorgernummer)
        {
            string werkingsduur = db.DuurVaccinatie(dierverzorgernummer);
            return werkingsduur;
        }
        #endregion

        #region Werkingsduur vaccinatie opvragen met dierverzorgernaam
        public string WerkingsduurVaccinatieVerzorger(string dierverzorgernaam)
        {
            string werkingsduur = db.WerkingsduurVaccinatie(dierverzorgernaam);
            return werkingsduur;
        }
        #endregion

        #region Vaccinatie verlopen op met dierverzorgernummer
        public DateTime VaccinatieVerlopenOp(int dierverzorgernummer)
        {
            DateTime verlopen = (DateTime)db.VaccinatieVerlopenOp(dierverzorgernummer);
            return verlopen;
        }
        #endregion

        #region Vaccinatie verlopen op met dierverzorgernaam
        public DateTime VaccinatieVerlopenOp(string dierverzorgernaam)
        {
            DateTime datum = (DateTime)db.VaccinatieVerlopen(dierverzorgernaam);
            return datum;
        }
        #endregion

        #region Vaccinaties van dierverzoger opvragen
        public List<Vaccinatie> VaccinatieDierverzorger(int dierverzorgernummer)
        {
            List<Vaccinatie> vaccinaties = (List<Vaccinatie>)db.VaccinatiesDierverzorger(dierverzorgernummer);
            return vaccinaties;
        }
        #endregion

        #region Vaccinaties van dierverzorger opvragen met naam
        public List<Vaccinatie> VaccinatiesDierverzorger(string dierverzorgernaam)
        {
            List<Vaccinatie> vaccinaties = (List<Vaccinatie>)db.VaccinatiesDierverzorger(dierverzorgernaam);
            return vaccinaties;
        }
        #endregion

        #region Dierverzorger toevoegen
        public void VoegToe(Dierverzorger dierverzorger)
        {
            db.DierverzorgerToevoegen(dierverzorger);
        }
        #endregion

        #region Dierverzorger verwijderen
        public void Verwijder(int dierverzorgernummer)
        {
            db.VerwijderDierverzorger(dierverzorgernummer);
        }
        #endregion

        #region Dierenarts toevoegen
        public void VoegToe(Dierenarts dierenarts)
        {
            db.DierenartsToevoegen(dierenarts);
        }
        #endregion

        #region Dierenarts verwijderen
        public void VerwijderArts(int dierenartsnummer)
        {
            db.VerwijderDierenarts(dierenartsnummer);
        }
        #endregion

        #region Verblijf zoeken
        public Huisvesting ZoekHuisvesting(int diersoortnummer)
        {
            Huisvesting huisvesting = (Huisvesting)db.HuisvestingDiersoort(diersoortnummer);
            return huisvesting;
        }
        #endregion

        #region Diersoort toevoegen
        public void VoegToeDiersoort(Diersoort diersoort)
        {
            db.VoegDiersoortToe(diersoort);
        }
        #endregion

        #region Vaccinatiedatum toevoegen
        public void VoegToeVaccinatiedatum(int dierverzorgernummer, string vaccinatienaam, DateTime datumgevaccineerd, DateTime datumverlopen, string bijwerking)
        {
            db.VoegVaccinatiedatumToe(dierverzorgernummer, vaccinatienaam, datumgevaccineerd, datumverlopen, bijwerking);
        }
        #endregion
        
    }
}
