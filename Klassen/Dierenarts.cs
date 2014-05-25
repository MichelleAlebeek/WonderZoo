﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    class Dierenarts : Persoon
    {
        private int dierenartsnummer;
        private int rekeningnummer;
        private string specialisatie;
        private int spoednummer;
        private int telefoonnummer;

        public Dierenarts(int dierenartsnummer, int rekeningnummer, string specialisatie, int spoednummer, int telefoonnummer, string naam, int leeftijd, string wachtwoord)
            : base(naam, leeftijd, wachtwoord)
        {
            this.dierenartsnummer = dierenartsnummer;
            this.rekeningnummer = rekeningnummer;
            this.specialisatie = specialisatie;
            this.spoednummer = spoednummer;
            this.telefoonnummer = telefoonnummer;
        }

        public int Dierenartsnummer
        {
            get { return dierenartsnummer; }
            set { dierenartsnummer = value; }
        }
        public int Rekeningnummer
        {
            get { return rekeningnummer; }
            set { rekeningnummer = value; }
        }
        public string Specialisatie
        {
            get { return specialisatie; }
            set { specialisatie = value; }
        }
        public int Spoednummer
        {
            get { return spoednummer; }
            set { spoednummer = value; }
        }
        public int Telefoonnummer
        {
            get { return telefoonnummer; }
            set { telefoonnummer = value; }
        }

        public int BerekenDuurMedicijn(DateTime vandaag, DateTime begindatum)
        {
            // TODO bereken hoelang het medicijn al gebruikt wordt.
            return 0;
        }

        public Medicijn ZoekMedicijn(int diernummer)
        {
            // TODO zoek bij het meegegeven diernummer het medicijn op die dit dier gebruikt.
            return null;
        }

        public string ZoekVeelvoorkomendeZiektes(string rasnaam)
        {
            // TODO zoek de veelvoorkomende ziektes op die bij het ras horen met het meegegeven rasnaam
            return null;
        }

        public override string ToString()
        {
            return dierenartsnummer + rekeningnummer + specialisatie + spoednummer + telefoonnummer;
        }
    }
}
