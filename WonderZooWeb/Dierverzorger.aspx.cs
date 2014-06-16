//Dierverzorger web form. Hier kan alleen de dierverzorger op terrecht komen en hier komen ook alleen de dingen te staan die een dierverzorg mag.

namespace WonderZooWeb
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using Klassen;
    public partial class Dierverzorger : System.Web.UI.Page
    {
        private Beheer beheerder;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.beheerder = new Beheer();
        }

        protected void BtnMedicijnen_Click(object sender, EventArgs e)
        {
            try
            {
                List<Medicijn> medicijnen = new List<Medicijn>(this.beheerder.MedicijnVanDier(Convert.ToInt32(TxtDierNr.Text)));

                GVMedicijnen.DataSource = medicijnen;
                GVMedicijnen.DataBind();
            }
            catch
            {
                LblMedicijn.Text = "Het dier gebruikt geen medicijnen";
            }
        }

        protected void BtnDiersoortInfo_Click(object sender, EventArgs e)
        {
            try
            {
                Diersoort diersoort = this.beheerder.ZoekDiersoort(Convert.ToInt32(TxtDiersoortNr.Text));
                TxtDiersoort.Text = diersoort.ToString();
            }
            catch
            {
                LblDiersoort.Text = "Het diersoort is niet bekend";
            }
        }

        protected void BtnInfoDier_Click(object sender, EventArgs e)
        {
            try
            {
                Dier dier = this.beheerder.InfoDier(TxtDiernaam.Text);
                TxtDier.Text = dier.ToString();
            }
            catch
            {
                LblDier.Text = "Geen dier bekend met deze naam";
            }
        }

        protected void BtnRas_Click(object sender, EventArgs e)
        {
            try
            {
                string ras = this.beheerder.RasVanDier(Convert.ToInt32(TxtDierNummer.Text));
                TxtRas.Text = ras;
            }
            catch
            {
                LblRas.Text = "Kan geen ras opvragen";
            }
        }

        protected void BtnZiektes_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> ziektes = this.beheerder.VeelVoorkomendeZiektesDiersoort(Convert.ToInt32(TxtDiersoortNummer.Text));
                GVZiektes.DataSource = ziektes;
                GVZiektes.DataBind();
            }
            catch
            {
                LblZiektes.Text = "Geen ziektes bekend";
            }
        }

        protected void BtnVerblijfDier_Click(object sender, EventArgs e)
        {
            try
            {
                string verblijf = this.beheerder.VerblijfVanDier(Convert.ToInt32(TxtDNr.Text));
                TxtVerblijf.Text = verblijf;
            }
            catch
            {
                LblVerblijf.Text = "Geen verblijf bekend";
            }
        }

        protected void BtnAantalVerblijf_Click(object sender, EventArgs e)
        {
            try
            {
                int aantal = this.beheerder.AantalDierenVeblijf(Convert.ToInt32(TxtHuisNr.Text));
                TxtAantal.Text = aantal.ToString();
            }
            catch
            {
                LblHuisvesting.Text = "Er komt geen huisvesting voor met dat nummer";
            }
        }

        protected void BtnVoedingDiersoort_Click(object sender, EventArgs e)
        {
            try
            {
                string voeding = this.beheerder.VoedingDiersoort(Convert.ToInt32(TxtDSoortNr.Text));
                TxtVoeding.Text = voeding;
            }
            catch
            {
                LblVoeding.Text = "Er is geen voeding bekend voor deze diersoort";
            }
        }

        protected void BtnHuisvestingDiersoort_Click(object sender, EventArgs e)
        {
            try
            {
                string huisvesting = this.beheerder.HuisvestingDiersoort(Convert.ToInt32(TxtDSoortNummer.Text));
                TxtHuisvesting.Text = huisvesting;
            }
            catch
            {
                LblHuisDiersoort.Text = "Er is geen huisvesting bekend voor deze diersoort";
            }
        }

        protected void BtnDierenTotaal_Click(object sender, EventArgs e)
        {
            try
            {
                int aantal = this.beheerder.TotaalAantalDieren();
                TxtTotaalDieren.Text = aantal.ToString();
            }
            catch
            {
                LblTotaal.Text = "Er zijn geen dieren aanwezig";
            }
        }

        protected void BtnUitloggen_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}