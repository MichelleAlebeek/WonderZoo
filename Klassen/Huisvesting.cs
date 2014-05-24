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

        public Huisvesting(int Huisvestingnummer, HuisvestingSoort SoortHuisvesting, HuisvestingMateriaal Materiaal, Gedragsverrijking Gedragsverrijking, int AantalDieren)
        {
            this.Huisvestingnummer = Huisvestingnummer;
            this.SoortHuisvesting = SoortHuisvesting;
            this.Materiaal = Materiaal;
            this.Gedragsverrijking = Gedragsverrijking;
            this.AantalDieren = AantalDieren;
            dieren = new List<Dier>();
        }

        //Na kijken of dit klopt.
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
            return 0;
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
