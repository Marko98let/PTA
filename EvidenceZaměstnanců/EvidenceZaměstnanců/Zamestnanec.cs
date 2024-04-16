using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceZaměstnanců
{
    public class Zamestnanec
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int ID { get; set; }
        public DateTime DatumNarozeni { get; set; }
        public Zamestnanec(string jmeno, string prijmeni, int iD, DateTime datumNarozeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            ID = iD;
            DatumNarozeni = datumNarozeni;
        }

        public override string? ToString()
        {
            return "Jmeno: " + Jmeno + "Prijmeni: " + Prijmeni + "ID: " + ID + "Datum Narození: " + DatumNarozeni;
        }
    }
}
