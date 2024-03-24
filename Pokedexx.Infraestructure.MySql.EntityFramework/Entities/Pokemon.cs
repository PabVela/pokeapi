using System;
using System.Collections.Generic;

namespace Pokedexx.Infraestructure.MySql.EntityFramework.Entities;

public partial class Pokemon
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int BaseExperience { get; set; }

    public int Height { get; set; }

    public int Weight { get; set; }

    public int IsDefault { get; set; }

    public int Order { get; set; }

    public string? LocationAreaEncounters { get; set; }
}
