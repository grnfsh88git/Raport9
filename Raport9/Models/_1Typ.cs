using System;
using System.Collections.Generic;

namespace Raport9.Models;

public partial class _1Typ
{
    public int IdTyp { get; set; }

    public string? Typ { get; set; }

    public virtual Table1? Table1 { get; set; }

    public virtual _1Glowna? _1Glowna { get; set; }
}
