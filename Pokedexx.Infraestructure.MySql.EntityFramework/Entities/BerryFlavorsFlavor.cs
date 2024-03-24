using System;
using System.Collections.Generic;

namespace Pokedexx.Infraestructure.MySql.EntityFramework.Entities;

public partial class BerryFlavorsFlavor
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Url { get; set; } = null!;

    public virtual ICollection<BerryNmFlavorInFlavor> BerryNmFlavorInFlavors { get; set; } = new List<BerryNmFlavorInFlavor>();
}
