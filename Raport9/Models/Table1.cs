using System;
using System.Collections.Generic;

namespace Raport9.Models;

public partial class Table1
{
    public int Id { get; set; }

    public int IdGlowna { get; set; }

    public string? Opis { get; set; }

    public virtual _1Typ IdNavigation { get; set; } = null!;
}
