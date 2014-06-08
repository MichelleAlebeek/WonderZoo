using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    class Huisvesting
    {
        private int aantalDieren;
        private Gedragsverrijking gedragsverrijking;
        private int huisvestingnummer;
        private HuisvestingMateriaal materiaal;
        private HuisvestingSoort soorthuisvesting;
        private List<Dier> dieren;
        private Beheer beheerder;

        public Huisvesting(int huisvestingnummer, HuisvestingSoort soorthuisvesting, HuisvestingMateriaal materiaal, Gedragsverrijking gedragsverrijking, int aantalDieren)
        {
            this.huisvestingnummer = huisvestingnummer;
            this.soorthuisvesting = soorthuisvesting;
            this.materiaal = materiaal;
            this.gedragsverrijking = gedragsverrijking;
            this.aantalDieren = aantalDieren;
            dieren = new List<Dier>();
            beheerder = new Beheer();
        }

        public List<Dier> Dieren
        {
            get { return new List<Dier>(dieren);}
        }

        public int AantalDieren
        {
            get { return aantalDieren; }
            set { aantalDieren = value; }
        }

        public Gedragsverrijking Gedragsverrijking
        {
            get { return gedragsverrijking; }
            set { gedragsverrijking = value; }
        }

        public int Huisvestingnummer
        {
            get { return huisvestingnummer; }
            set { huisvestingnummer = value; }
        }

        public HuisvestingMateriaal Materiaal
        {
            get { return materiaal; }
            set { materiaal = value; }
        }

        public HuisvestingSoort SoortHuisvesting
        {
            get { return soorthuisvesting; }
            set { soorthuisvesting = value; }
        }

        public int BerekenAantalDieren(int huisvestingnummer)
        {
            // TODO: 
            // Bereken het aantal dieren in het verblijf met het huisvestingnummer dat wordt meegegeven
            int aantal = beheerder.AantalDierenVeblijf(huisvestingnummer);
            return aantal;
        }

        public override string ToString()
        {
            return huisvestingnummer + soorthuisvesting + "Materiaal: " + materiaal + gedragsverrijking + aantalDieren + dieren;
        }
    }

    public enum HuisvestingSoort
    {
        Aquarium,
        Bosachtig,
        BosachtigGroot,
        BosachtigeVoliére,
        Grasvlakte,
        Safari,
        Terrarium,
        Voliére,
        Woestijn,
        WoestijnEnSafari
    }

    public enum HuisvestingMateriaal
    {
        Bomen,
        Gras,
        Houtsnippers,
        Speelzand,
        Steentjes,
        Struiken,
        Water,
        Zand
    }

    public enum Gedragsverrijking
    {
        Bergen,
        Boomstammen,
        BoomstamMetEenHolte,
        Broedplaats,
        Graafmogelijkheden,
        Grassen,
        HogePalen,
        HolleBoomstam,
        Hoogteverschillen,
        Klimmogelijkheden,
        Moeras,
        SpijkersWaarFruitAanKanHangen,
        Struiken,
        VerstopMogelijkheden,
        VoedselVerstoppen,
        Water,
        WilgenTakken
    }
}
