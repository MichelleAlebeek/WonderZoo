using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WonderZooWeb
{
    public partial class Inloggen : System.Web.UI.Page
    {
        Klassen.Beheer beheerder;
        protected void Page_Load(object sender, EventArgs e)
        {
            beheerder = new Klassen.Beheer();
        }

        protected void BtnInloggen_Click(object sender, EventArgs e)
        {
            Klassen.Persoon gebruiker = (Klassen.Persoon)beheerder.Inloggen(TxtGebruikersnaam.Text, TxtWachtwoord.Text);

            if (gebruiker.Beroep == "Dierverzorger")
            {
                Response.Redirect("Dierverzorger.aspx");
            }
            else if (gebruiker.Beroep == "Dierenarts")
            {
                Response.Redirect("Dierenarts.aspx");
            }
            else if (gebruiker.Beroep == "Directeur")
            {
                Response.Redirect("Directeur.aspx");
            }
            else if (gebruiker.Beroep == "Administratie")
            {
                Response.Redirect("Administratie.aspx");
            }
            else
            {
                LblFout.Text = "Ongeldige combinatie wachtwoord en gebruikersnaam";
            }
        }

        protected void BtnAnnuleren_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}