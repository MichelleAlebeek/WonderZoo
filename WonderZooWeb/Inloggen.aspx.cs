//Inloggen web form. Op dit form kunnen alle gebruikers terrecht komen, maar alleen de gebruikers die in de database voorkomen kunnen ook daadwerkelijk inloggen met het juiste wachtwoord en gebruikersnaam.
namespace WonderZooWeb
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class Inloggen : System.Web.UI.Page
    {
        private Klassen.Beheer beheerder;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.beheerder = new Klassen.Beheer();
        }

        protected void BtnInloggen_Click(object sender, EventArgs e)
        {
            try
            { 
                Klassen.Persoon gebruiker = (Klassen.Persoon)this.beheerder.Inloggen(TxtGebruikersnaam.Text, TxtWachtwoord.Text);

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
            }
            catch
            {
                    LblFout.Text = "Ongeldige combinatie wachtwoord en gebruikersnaam";
                    TxtGebruikersnaam.Text = string.Empty;
                    TxtWachtwoord.Text = string.Empty;
            }
        }

        protected void BtnAnnuleren_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}