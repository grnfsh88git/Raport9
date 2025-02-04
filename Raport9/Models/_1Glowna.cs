using System;
using System.Collections.Generic;

namespace Raport9.Models;

public partial class _1Glowna
{
    public int Id { get; set; }

    public string? Typ { get; set; }

    public string? Imie { get; set; }

    public string? Nazwisko { get; set; }

    public string? Zadanie { get; set; }

    public int? Wtryskarka { get; set; }

    public string? NrArt { get; set; }

    public string? IdTyp { get; set; }

    public int? Zmiana { get; set; }

    public virtual _1Typ IdNavigation { get; set; } = null!;
}
