using System;
using System.Collections.Generic;

namespace Pokedexx.Infraestructure.MySql.EntityFramework.Entities;

public partial class BerryItem
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Url { get; set; }

    public virtual ICollection<Berry> Berries { get; set; } = new List<Berry>();
}
