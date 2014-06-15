using Klassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WonderZooWeb
{
    public partial class Dierverzorger : System.Web.UI.Page
    {
        Beheer beheerder;
        protected void Page_Load(object sender, EventArgs e)
        {
            beheerder = new Beheer();
        }

        protected void BtnMedicijnen_Click(object sender, EventArgs e)
        {
            List<Medicijn> medicijnen = new List<Medicijn>(beheerder.MedicijnVanDier(Convert.ToInt32(TxtDierNr.Text)));

            GVMedicijnen.DataSource = medicijnen;
            GVMedicijnen.DataBind();
        }

        protected void BtnDiersoortInfo_Click(object sender, EventArgs e)
        {
            Diersoort diersoort = beheerder.ZoekDiersoort(Convert.ToInt32(TxtDiersoortNr.Text));
            TxtDiersoort.Text = diersoort.ToString();
        }

        protected void BtnInfoDier_Click(object sender, EventArgs e)
        {
            Dier dier = beheerder.InfoDier(TxtDiernaam.Text);
            TxtDier.Text = dier.ToString();
        }

        protected void BtnRas_Click(object sender, EventArgs e)
        {
            string ras = beheerder.RasVanDier(Convert.ToInt32(TxtDierNummer.Text));
            TxtRas.Text = ras;
        }

        protected void BtnZiektes_Click(object sender, EventArgs e)
        {
            List<String> ziektes = beheerder.VeelVoorkomendeZiektesDiersoort(Convert.ToInt32(TxtDiersoortNummer.Text));
            GVZiektes.DataSource = ziektes;
            GVZiektes.DataBind();
        }

        protected void BtnVerblijfDier_Click(object sender, EventArgs e)
        {
            string verblijf = beheerder.VerblijfVanDier(Convert.ToInt32(TxtDNr.Text));
            TxtVerblijf.Text = verblijf;
        }

        protected void BtnAantalVerblijf_Click(object sender, EventArgs e)
        {
            int aantal = beheerder.AantalDierenVeblijf(Convert.ToInt32(TxtHuisNr.Text));
            TxtAantal.Text = aantal.ToString();
        }

        protected void BtnVoedingDiersoort_Click(object sender, EventArgs e)
        {
            string voeding = beheerder.VoedingDiersoort(Convert.ToInt32(TxtDSoortNr.Text));
            TxtVoeding.Text = voeding;
        }

        protected void BtnHuisvestingDiersoort_Click(object sender, EventArgs e)
        {
            string huisvesting = beheerder.HuisvestingDiersoort(Convert.ToInt32(TxtDSoortNr.Text));
            TxtHuisvesting.Text = huisvesting;
        }

        protected void BtnDierenTotaal_Click(object sender, EventArgs e)
        {
            int aantal = beheerder.TotaalAantalDieren();
            TxtTotaalDieren.Text = aantal.ToString();
        }

        protected void BtnUitloggen_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}