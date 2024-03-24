using System;
using System.Collections.Generic;

namespace Pokedexx.Infraestructure.MySql.EntityFramework.Entities;

public partial class BerryNmFlavorInFlavor
{
    public int Id { get; set; }

    public int FlavorsId { get; set; }

    public int FlavorId { get; set; }

    public virtual BerryFlavorsFlavor Flavor { get; set; } = null!;

    public virtual BerryFlavor Flavors { get; set; } = null!;
}
