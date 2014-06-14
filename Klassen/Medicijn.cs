using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
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
            get { return medicijnnaam; }
            set { medicijnnaam = value; }
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


        public override string ToString()
        {
            return "Medicijn: " + medicijnnaam + "hoeveelheid: " + hoeveelheid + "bijwerkingen: " + bijwerking;
        }
    }

    public enum Medicijnnaam
    {
        Antibiotica,
        Roosvicé,
        Suiker,
        Zoutoplossing,
        Suikeroplossing
    }
}
