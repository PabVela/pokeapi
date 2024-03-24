using System;
using System.Collections.Generic;

namespace Pokedexx.Infraestructure.MySql.EntityFramework.Entities;

public partial class BerryFlavor
{
    public int Int { get; set; }

    public int FlavorList { get; set; }

    public virtual ICollection<BerryNmFlavorInFlavor> BerryNmFlavorInFlavors { get; set; } = new List<BerryNmFlavorInFlavor>();
}
