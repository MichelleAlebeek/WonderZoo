using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    class Beheer
    {
        private Administratie administratie;

        public Beheer(Administratie administratie)
        {
            this.administratie = administratie;
        }

        public Administratie Administratie
        {
            get { return administratie; }
        }
    }
}
