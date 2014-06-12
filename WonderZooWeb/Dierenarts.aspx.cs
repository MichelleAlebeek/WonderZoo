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
            List<Medicijn> medicijnen = new List<Medicijn>(beheerder.MedicijnVanDier(diernummer));

            try
            {
                foreach (Medicijn med in medicijnen)
                {
                    ListBox1.Items.Add(med.ToString());
                }
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
            int duurmedicijn = Convert.ToInt32((startdatum - DateTime.Today));
            TxtDuurMedicijn.Text = Convert.ToString(duurmedicijn);
        }

        protected void BtnZiektes_Click(object sender, EventArgs e)
        {
            List<Diersoort> diersoorten = new List<Diersoort>(beheerder.ZoekDiersoortLijst());
            string diersoortnaam = TxtDiersoortnaam.Text;
            int diersoortnummer;
            foreach (Diersoort diersoort in diersoorten)
            {
                if (diersoort.Familie == diersoortnaam)
                {
                    diersoortnummer = diersoort.Diersoortnummer;
                    string ziektes = beheerder.VeelVoorkomendeZiektesDiersoort(diersoortnummer);
                    ListBox1.Items.Add(ziektes);
                }
            }          
        }
    }
}