// Klassen medicijn

namespace Klassen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public enum Medicijnnaam
    {
        Antibiotica,
        Roosvicé,
        Suiker,
        Zoutoplossing,
        Suikeroplossing
    }
    public class Medicijn
    {
        private string bijwerking;
        private string hoeveelheid;
        private Medicijnnaam medicijnnaam;

        public Medicijn (Medicijnnaam medicijnnaam, string hoeveelheid, string bijwerking)
        {
            this.medicijnnaam = medicijnnaam;
            this.hoeveelheid = hoeveelheid;
            this.bijwerking = bijwerking;
        }

        public Medicijnnaam Medicijnnaam
        {
            get { return this.medicijnnaam; }
            set { this.medicijnnaam = value; }
        }

        public string Bijwerking
        {
            get { return this.bijwerking; }
            set { this.bijwerking = value; }
        }
        public string Hoeveelheid
        {
            get { return this.hoeveelheid; }
            set { this.hoeveelheid = value; }
        }

        public override string ToString()
        {
            return "Medicijn: " + this.medicijnnaam + "hoeveelheid: " + this.hoeveelheid + "bijwerkingen: " + this.bijwerking;
        }
    }
}
