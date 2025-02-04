using System;
using System.Collections.Generic;

namespace Raport9.Models;

public partial class Prezentacja
{
    public double? NrWtr { get; set; }

    public string? Wtr { get; set; }

    public string? Robot { get; set; }

    public string? NrArt { get; set; }

    public string? Typ { get; set; }

    public string? Opis { get; set; }

    public string? Kto { get; set; }

    public string? Kiedy { get; set; }

    public int? Zmiana { get; set; }

    public byte? Miesiac { get; set; }

    public int? Rok { get; set; }

    public string? Czasprestoju { get; set; }

    public DateTime? Czaspracy { get; set; }

    public int Id { get; set; }

    public string? Data { get; set; }
}
