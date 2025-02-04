using System;
using System.Collections.Generic;

namespace Raport9.Models;

public partial class Przezbrojenium
{
    public DateTime? Data { get; set; }

    public string? Artykuł { get; set; }

    public double? Wtr { get; set; }

    public double? Zmiana { get; set; }

    public string? Automatyk { get; set; }

    public string? Wykonane { get; set; }

    public string? Uwagi { get; set; }

    public string? MontażM { get; set; }

    public string? DemontażD { get; set; }

    public string? KrokowanieK { get; set; }

    public string? StartS { get; set; }

    public int Id { get; set; }
}
