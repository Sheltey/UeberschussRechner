using System;
using System.Collections.Generic;
using UeberschussRechner.Server.Objects;

namespace Server.Repositories.CsvInBuchungUebersetzen
{
    interface ICsvInBuchungUebersetzenRepositorie
    {
        IList<Buchung> DatenInBuchungenUebersetzen(string[] daten);

    }
}
