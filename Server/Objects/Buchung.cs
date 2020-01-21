using System;

namespace UeberschussRechner.Server.Objects
{
    public class Buchung
    {

        public int Nummer { get; set; }
        public DateTime Datum { get; set; }
        public double? Einnahme { get; set; }
        public double? Ausgabe { get; set; }
        public string Text { get; set; }

        private Buchung(int nummer, DateTime datum, double? einnahme, double? ausgabe, string text)
        {
            Nummer = nummer;
            Datum = datum;
            Einnahme = einnahme;
            Ausgabe = ausgabe;
            Text = text;
        }

        public Buchung CreateBuchung(int nummer, DateTime datum, double? einnahme, double? ausgabe, string text)
        {
            return new Buchung(nummer, datum, einnahme, ausgabe, text);
        }

    }
}
