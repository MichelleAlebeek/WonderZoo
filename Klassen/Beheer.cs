using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klassen.Properties;
using Databasekoppeling;

namespace Klassen
{
    class Beheer
    {
        private Databasekoppeling.Databasekoppeling db;
        public Beheer()
        {
            db = new Databasekoppeling.Databasekoppeling();
            
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
        public string MedicijnVanDier(int diernummer)
        {
           string medicijn = db.MedicijnDierOpvragen(diernummer);
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
            string huisvesting = db.HuisvestingDiersoort(diersoortnummer);
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

    }
}
