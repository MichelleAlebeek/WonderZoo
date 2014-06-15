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
            List<Medicijn> medicijnen = new List<Medicijn>(this.beheerder.MedicijnVanDier(Convert.ToInt32(TxtDierNr.Text)));

            GVMedicijnen.DataSource = medicijnen;
            GVMedicijnen.DataBind();
        }

        protected void BtnDiersoortInfo_Click(object sender, EventArgs e)
        {
            Diersoort diersoort = this.beheerder.ZoekDiersoort(Convert.ToInt32(TxtDiersoortNr.Text));
            TxtDiersoort.Text = diersoort.ToString();
        }

        protected void BtnInfoDier_Click(object sender, EventArgs e)
        {
            Dier dier = this.beheerder.InfoDier(TxtDiernaam.Text);
            TxtDier.Text = dier.ToString();
        }

        protected void BtnRas_Click(object sender, EventArgs e)
        {
            string ras = this.beheerder.RasVanDier(Convert.ToInt32(TxtDierNummer.Text));
            TxtRas.Text = ras;
        }

        protected void BtnZiektes_Click(object sender, EventArgs e)
        {
            List<string> ziektes = this.beheerder.VeelVoorkomendeZiektesDiersoort(Convert.ToInt32(TxtDiersoortNummer.Text));
            GVZiektes.DataSource = ziektes;
            GVZiektes.DataBind();
        }

        protected void BtnVerblijfDier_Click(object sender, EventArgs e)
        {
            string verblijf = this.beheerder.VerblijfVanDier(Convert.ToInt32(TxtDNr.Text));
            TxtVerblijf.Text = verblijf;
        }

        protected void BtnAantalVerblijf_Click(object sender, EventArgs e)
        {
            int aantal = this.beheerder.AantalDierenVeblijf(Convert.ToInt32(TxtHuisNr.Text));
            TxtAantal.Text = aantal.ToString();
        }

        protected void BtnVoedingDiersoort_Click(object sender, EventArgs e)
        {
            string voeding = this.beheerder.VoedingDiersoort(Convert.ToInt32(TxtDSoortNr.Text));
            TxtVoeding.Text = voeding;
        }

        protected void BtnHuisvestingDiersoort_Click(object sender, EventArgs e)
        {
            string huisvesting = this.beheerder.HuisvestingDiersoort(Convert.ToInt32(TxtDSoortNr.Text));
            TxtHuisvesting.Text = huisvesting;
        }

        protected void BtnDierenTotaal_Click(object sender, EventArgs e)
        {
            int aantal = this.beheerder.TotaalAantalDieren();
            TxtTotaalDieren.Text = aantal.ToString();
        }

        protected void BtnUitloggen_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}