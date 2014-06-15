//Klasse vaccinatie. Deze klasse bevat alle attributen van een vaccinatie. 

namespace Klassen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Vaccinatie
    {
        private double prijs;
        private string uitPreventieVoor;
        private string vaccinatienaam;
        private string werkingstijd;

        public Vaccinatie(string vaccinatienaam, string werkingstijd, string uitPreventieVoor, double prijs)
        {
            this.prijs = prijs;
            this.uitPreventieVoor = uitPreventieVoor;
            this.vaccinatienaam = vaccinatienaam;
            this.werkingstijd = werkingstijd;
        }

        public string Vaccinatienaam
        {
            get { return this.vaccinatienaam; }
            set { this.vaccinatienaam = value; }
        }
       
        public string UitPreventieVoor
        {
            get { return this.uitPreventieVoor; }
            set { this.uitPreventieVoor = value; }
        }
    
        public string Werkingstijd
        {
            get { return this.werkingstijd; }
            set { this.werkingstijd = value; }
        }
        public double Prijs
        {
            get { return this.prijs; }
            set { this.prijs = value; }
        }

        public override string ToString()
        {
            return this.vaccinatienaam + this.uitPreventieVoor + this.werkingstijd + this.prijs;
        }
    }
}
