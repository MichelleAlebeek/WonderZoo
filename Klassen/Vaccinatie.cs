using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
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

        public double Prijs
        {
            get { return prijs; }
            set { prijs = value; }
        }
        public string UitPreventieVoor
        {
            get { return uitPreventieVoor; }
            set { uitPreventieVoor = value; }
        }
        public string Vaccinatienaam
        {
            get { return vaccinatienaam; }
            set { vaccinatienaam = value; }
        }
        public string Werkingstijd
        {
            get { return werkingstijd; }
            set { werkingstijd = value; }
        }

        public override string ToString()
        {
            return vaccinatienaam + uitPreventieVoor + werkingstijd + prijs;
        }
    }
}
