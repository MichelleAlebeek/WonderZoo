//Klassen huisvesting

namespace Klassen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
    public class Huisvesting
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
            this.dieren = new List<Dier>();
            this.beheerder = new Beheer();
        }

        public List<Dier> Dieren
        {
            get { return new List<Dier>(this.dieren); }
        }

        public int AantalDieren
        {
            get { return this.aantalDieren; }
            set { this.aantalDieren = value; }
        }

        public Gedragsverrijking Gedragsverrijking
        {
            get { return this.gedragsverrijking; }
            set { this.gedragsverrijking = value; }
        }

        public int Huisvestingnummer
        {
            get { return this.huisvestingnummer; }
            set { this.huisvestingnummer = value; }
        }

        public HuisvestingMateriaal Materiaal
        {
            get { return this.materiaal; }
            set { this.materiaal = value; }
        }

        public HuisvestingSoort SoortHuisvesting
        {
            get { return this.soorthuisvesting; }
            set { this.soorthuisvesting = value; }
        }

        public int BerekenAantalDieren(int huisvestingnummer)
        {
            // TODO: 
            // Bereken het aantal dieren in het verblijf met het huisvestingnummer dat wordt meegegeven
            int aantal = this.beheerder.AantalDierenVeblijf(huisvestingnummer);
            return aantal;
        }

        public override string ToString()
        {
            return this.huisvestingnummer + this.soorthuisvesting + "Materiaal: " + this.materiaal + this.gedragsverrijking + this.aantalDieren + this.dieren;
        }
    }   
}
