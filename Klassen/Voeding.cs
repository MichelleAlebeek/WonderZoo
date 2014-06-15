//Klasse voeding.

namespace Klassen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public enum Soortvoeding
    {
        Eieren,
        Fruit,
        Groente,
        Hondenbrok,
        Kattenbrok,
        Krachtvoer,
        Levendvoer,
        PandaCake,
        Rauwvlees,
        Ruwvoer,
        Schapenbrok
    }
    public class Voeding
    {
        private string hoeveelheidVoeding;
        private DateTime houdbaarTot;
        private string naamVoeding;
        private Soortvoeding soortVoeding;

        public Voeding (string naamVoeding, string hoeveelheidVoeding, DateTime houdbaarTot, Soortvoeding soortVoeding)
        {
            this.naamVoeding = naamVoeding;
            this.hoeveelheidVoeding = hoeveelheidVoeding;
            this.houdbaarTot = houdbaarTot;
            this.soortVoeding = soortVoeding;
        }

        public Soortvoeding SoortVoeding
        {
            get { return this.soortVoeding; }
            set { this.soortVoeding = value; }
        }

        public string HoeveelheidVoeding
        {
            get { return this.hoeveelheidVoeding; }
            set { this.hoeveelheidVoeding = value; }
        }

        public DateTime HoudbaarTot
        {
            get { return this.houdbaarTot; }
            set { this.houdbaarTot = value; }
        }

        public string NaamVoeding
        {
            get { return this.naamVoeding; }
            set { this.naamVoeding = value; }
        }

        public override string ToString()
        {
            return this.soortVoeding + this.naamVoeding + this.hoeveelheidVoeding + this.houdbaarTot;
        }
    } 
}
