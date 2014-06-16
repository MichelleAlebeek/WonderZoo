//Dierenarts web form. Hier kan alleen de dierenarts op terrecht komen en 

namespace WonderZooWeb
{
    using System.Collections.Generic;
    using System;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using Klassen;

    public partial class Dierenarts : System.Web.UI.Page
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
                int diernummer = Convert.ToInt32(TxtDierNr.Text);
                List<Medicijn> medicijnen = new List<Medicijn>(this.beheerder.MedicijnVanDier(diernummer));
                GVMedicijnen.DataSource = medicijnen;
                GVMedicijnen.DataBind();
            }
            catch
            {
                LblFout.Text = "Dier gebruikt geen medicijnen / is niet bekend";
            }
        }

        protected void BtnDuurMedicijn_Click(object sender, EventArgs e)
        {
            try
            {
                string diernaam = TxtDiernaam.Text;

                DateTime startdatum = this.beheerder.MedicijnStartdatum(diernaam);
                int duurmedicijn = (DateTime.Today - startdatum).Days;
                TxtDuurMedicijn.Text = Convert.ToString(duurmedicijn + " dag(en)");
            }
            catch
            {
                LblFout.Text = "Duur van het medicijn is niet bekend";
            }
        }

        protected void BtnZiektes_Click(object sender, EventArgs e)
        {
            try
            {
                int diersoortnummer = Convert.ToInt32(TxtDiersoortnaam.Text);
                List<string> ziektes = this.beheerder.VeelVoorkomendeZiektesDiersoort(diersoortnummer);
                GVZiektes.DataSource = ziektes;
                GVZiektes.DataBind(); 
            }
            catch
            {
                LblFout.Text = "Er zijn geen veel voorkomende ziektes van deze diersoort bekend";
            }
        }

        protected void BtnUitloggen_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}