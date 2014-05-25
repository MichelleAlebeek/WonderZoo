using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    class Voeding
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
            get { return soortVoeding; }
            set { soortVoeding = value; }
        }


        public string HoeveelheidVoeding
        {
            get { return hoeveelheidVoeding; }
            set { hoeveelheidVoeding = value; }
        }

        public DateTime HoudbaarTot
        {
            get { return houdbaarTot; }
            set { houdbaarTot = value; }
        }

        public string NaamVoeding
        {
            get { return naamVoeding; }
            set { naamVoeding = value; }
        }

        public override string ToString()
        {
            return soortVoeding + naamVoeding + hoeveelheidVoeding + houdbaarTot;
        }
    }

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
}
