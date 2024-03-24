using System;
using System.Collections.Generic;

namespace Pokedexx.Infraestructure.MySql.EntityFramework.Entities;

public partial class BerryFirmness
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Url { get; set; } = null!;

    public virtual ICollection<Berry> Berries { get; set; } = new List<Berry>();
}
