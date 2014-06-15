﻿//Directeur web form. Hier kan alleen de directeur op terrecht komen en komen ook alleen de dingen op te staan die een directeur mag.

namespace WonderZooWeb
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using Klassen;
    using Klassen.Properties;
    public partial class Directeur : System.Web.UI.Page
    {
        private Beheer beheerder;
        private Klassen.Directeur directeur;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.beheerder = new Beheer();
            this.directeur = new Klassen.Directeur("Jan", 45, "GeheimDirecteur", "Directeur");
        }

        protected void BtnTotaalDieren_Click(object sender, EventArgs e)
        {
            TxtAantalTotaal.Text = Convert.ToString(this.beheerder.TotaalAantalDieren());
        }

        protected void BtnVerblijf_Click(object sender, EventArgs e)
        {
            int diernummer = Convert.ToInt32(TxtDiersoortNr.Text);
            TxtVerblijf.Text = this.beheerder.VerblijfVanDier(diernummer);
        }

        protected void BtnMedicijnen_Click(object sender, EventArgs e)
        {
            int diernummer = Convert.ToInt32(TxtDierNr.Text);
            List<Medicijn> medicijnen = new List<Medicijn>(this.beheerder.MedicijnVanDier(diernummer));
            GVMedicijnen.DataSource = medicijnen;
            GVMedicijnen.DataBind();
        }

        protected void BtnAantalVerblijf_Click(object sender, EventArgs e)
        {
            int huisvesting = Convert.ToInt32(TxtHuisNr.Text);
            TxtAantalVerblijf.Text = Convert.ToString(this.beheerder.AantalDierenVeblijf(huisvesting));
        }

        protected void BtnToevoegen_Click(object sender, EventArgs e)
        {
            int diernummer = Convert.ToInt32(TxtDNr.Text);
            string diernaam = TxtDNaam.Text;
            int gewicht = Convert.ToInt32(TxtGewicht.Text);
            int lengte = Convert.ToInt32(TxtLengte.Text) ;
            string naammoeder = TxtNaamMoeder.Text; 
            string naamvader = TxtNaamVader.Text;
            int leeftijd = Convert.ToInt32(TxtLeeftijd.Text);
            string geslacht = TxtGeslacht.Text ;
            bool nakomeling;
            if (CkNakomeling.Checked == true)
            {
                nakomeling  = true;
            }
            else
            {
                nakomeling = false;
            }          
            DateTime aanschaf = DateTime.Today;

            try
            {
                Dier dier = new Dier(diernummer, diernaam, leeftijd, geslacht, gewicht, lengte, naammoeder, naamvader, nakomeling, aanschaf, 0, null, null, null, 0, 0, 0, 0, 0, null, null, 0, null, null, null, null, null);
                this.directeur.VoegToe(dier, Convert.ToInt32(TxtHuisNrDier.Text));
                
            }
            catch (Exception ex)
            {
                LblFout.Text = ex.Message;
            }
        }

        protected void BtnVerwijderen_Click(object sender, EventArgs e)
        {
            string diernaam = TxtNaam.Text;
            int diernummer = Convert.ToInt32(TxtNr.Text);
            this.beheerder.VerwijderDier(diernummer, diernaam);
        }

        protected void BtnUitloggen_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}