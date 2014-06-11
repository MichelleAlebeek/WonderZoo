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
        private DateTime startdatum;

        public Medicijn (Medicijnnaam medicijnnaam, string hoeveelheid, string bijwerking, DateTime startdatum)
        {
            this.medicijnnaam = medicijnnaam;
            this.hoeveelheid = hoeveelheid;
            this.bijwerking = bijwerking;
            this.startdatum = startdatum;
        }

        public string Bijwerking
        {
            get { return bijwerking; }
            set { bijwerking = value; }
        }
        public DateTime Startdatum
        {
            get { return startdatum; }
            set { startdatum = value; }
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
            return "Medicijn: " + medicijnnaam + "hoeveelheid: " + hoeveelheid + "bijwerkingen: " + bijwerking + "datum gestart: " + startdatum.Date;
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
