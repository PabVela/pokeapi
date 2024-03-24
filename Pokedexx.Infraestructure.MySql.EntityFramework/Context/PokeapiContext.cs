using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pokedexx.Infraestructure.MySql.EntityFramework.Entities;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace Pokedexx.Infraestructure.MySql.EntityFramework.Context;

public partial class PokeapiContext : DbContext
{
    public PokeapiContext()
    {
    }

    public PokeapiContext(DbContextOptions<PokeapiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Berry> Berries { get; set; }

    public virtual DbSet<BerryFirmness> BerryFirmnesses { get; set; }

    public virtual DbSet<BerryFlavor> BerryFlavors { get; set; }

    public virtual DbSet<BerryFlavorsFlavor> BerryFlavorsFlavors { get; set; }

    public virtual DbSet<BerryItem> BerryItems { get; set; }

    public virtual DbSet<BerryNaturalGiftType> BerryNaturalGiftTypes { get; set; }

    public virtual DbSet<BerryNmFlavorInFlavor> BerryNmFlavorInFlavors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=pokeapi;user=root;password=admin", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.36-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Berry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("berry");

            entity.HasIndex(e => e.Firmness, "frimness_fk_idx");

            entity.HasIndex(e => e.Item, "item_fk_idx");

            entity.HasIndex(e => e.NaturalGiftType, "natural_gift_type_idx");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Firmness).HasColumnName("firmness");
            entity.Property(e => e.GrowthTime).HasColumnName("growth_time");
            entity.Property(e => e.Item).HasColumnName("item");
            entity.Property(e => e.MaxHarvest).HasColumnName("max_harvest");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.NaturalGiftPower).HasColumnName("natural_gift_power");
            entity.Property(e => e.NaturalGiftType).HasColumnName("natural_gift_type");
            entity.Property(e => e.Size).HasColumnName("size");
            entity.Property(e => e.Smoothness).HasColumnName("smoothness");
            entity.Property(e => e.SoilDryness).HasColumnName("soil_dryness");

            entity.HasOne(d => d.FirmnessNavigation).WithMany(p => p.Berries)
                .HasForeignKey(d => d.Firmness)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("frimness_fk");

            entity.HasOne(d => d.ItemNavigation).WithMany(p => p.Berries)
                .HasForeignKey(d => d.Item)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("item_fk");

            entity.HasOne(d => d.NaturalGiftTypeNavigation).WithMany(p => p.Berries)
                .HasForeignKey(d => d.NaturalGiftType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("natural_gift_type");
        });

        modelBuilder.Entity<BerryFirmness>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("berry_firmness");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
        });

        modelBuilder.Entity<BerryFlavor>(entity =>
        {
            entity.HasKey(e => e.Int).HasName("PRIMARY");

            entity.ToTable("berry_flavors");

            entity.Property(e => e.Int)
                .ValueGeneratedNever()
                .HasColumnName("int");
            entity.Property(e => e.FlavorList).HasColumnName("flavor_list");
        });

        modelBuilder.Entity<BerryFlavorsFlavor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("berry_flavors_flavor");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
        });

        modelBuilder.Entity<BerryItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("berry_item");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
        });

        modelBuilder.Entity<BerryNaturalGiftType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("berry_natural_gift_type");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
        });

        modelBuilder.Entity<BerryNmFlavorInFlavor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("berry_nm_flavor_in_flavors");

            entity.HasIndex(e => e.FlavorId, "flavor_id_fk_idx");

            entity.HasIndex(e => e.FlavorsId, "flavors_id_fk_idx");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.FlavorId).HasColumnName("flavor_id");
            entity.Property(e => e.FlavorsId).HasColumnName("flavors_id");

            entity.HasOne(d => d.Flavor).WithMany(p => p.BerryNmFlavorInFlavors)
                .HasForeignKey(d => d.FlavorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("flavor_id_fk");

            entity.HasOne(d => d.Flavors).WithMany(p => p.BerryNmFlavorInFlavors)
                .HasForeignKey(d => d.FlavorsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("flavors_id_fk");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
