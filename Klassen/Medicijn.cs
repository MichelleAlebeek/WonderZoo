using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    class Medicijn
    {
        private string bijwerking;
        private string hoeveelheid;
        private Medicijnnaam medicijnnaam;

        public Medicijn (Medicijnnaam Medicijnnaam, string Hoeveelheid, string Bijwerking)
        {
            this.Medicijnnaam = Medicijnnaam;
            this.Hoeveelheid = Hoeveelheid;
            this.Bijwerking = Bijwerking;
        }

        public string Bijwerking
        {
            get { return bijwerking; }
            set { bijwerking = value; }
        }

        public string Hoeveelheid
        {
            get { return hoeveelheid; }
            set { hoeveelheid = value; }
        }

        public Medicijnnaam Medicijnnaam
        {
            get { return medicijnnaam; }
            set { medicijnnaam = value; }
        }

        public override string ToString()
        {
            return Medicijnnaam + Hoeveelheid + Bijwerking;
        }
    }

    public enum Medicijnnaam
    {
        Antibiotica,
        Roosvicé,
        Suiker,
        Zoutoplossing
    }
}
