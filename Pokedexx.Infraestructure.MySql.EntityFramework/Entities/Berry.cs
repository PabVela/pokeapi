using System;
using System.Collections.Generic;

namespace Pokedexx.Infraestructure.MySql.EntityFramework.Entities;

public partial class Berry
{
    public int Id { get; set; }

    public int GrowthTime { get; set; }

    public int MaxHarvest { get; set; }

    public string Name { get; set; } = null!;

    public int NaturalGiftPower { get; set; }

    public int Size { get; set; }

    public int Smoothness { get; set; }

    public int SoilDryness { get; set; }

    public int Firmness { get; set; }

    public int Item { get; set; }

    public int NaturalGiftType { get; set; }

    public virtual BerryFirmness FirmnessNavigation { get; set; } = null!;

    public virtual BerryItem ItemNavigation { get; set; } = null!;

    public virtual BerryNaturalGiftType NaturalGiftTypeNavigation { get; set; } = null!;
}
