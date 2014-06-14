using Klassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WonderZooWeb
{
    public partial class Dierenarts : System.Web.UI.Page
    {
        Beheer beheerder;
        protected void Page_Load(object sender, EventArgs e)
        {
            beheerder = new Beheer();
        }

        protected void BtnMedicijnen_Click(object sender, EventArgs e)
        {
            int diernummer = Convert.ToInt32(TxtDierNr.Text);
            
            try
            {
                List<Medicijn> medicijnen = new List<Medicijn>(beheerder.MedicijnVanDier(diernummer));
                GVArts.DataSource = medicijnen;
                GVArts.DataBind();
            }
            catch (Exception ex)
            {
                LblFout.Text = ex.Message;
            }
        }

        protected void BtnDuurMedicijn_Click(object sender, EventArgs e)
        {
            string diernaam = TxtDiernaam.Text;
            
            DateTime startdatum = beheerder.MedicijnStartdatum(diernaam);       
            int duurmedicijn = (DateTime.Today - startdatum).Days;
            TxtDuurMedicijn.Text = Convert.ToString(duurmedicijn + " dag(en)");
        }

        protected void BtnZiektes_Click(object sender, EventArgs e)
        {
            int diersoortnummer = Convert.ToInt32(TxtDiersoortnaam.Text);
            List<String> ziektes = beheerder.VeelVoorkomendeZiektesDiersoort(diersoortnummer);
            GVArts.DataSource = ziektes;
            GVArts.DataBind();
        }
    }
}