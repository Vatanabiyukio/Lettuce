using Microsoft.EntityFrameworkCore;
using Pumpkin.Entities;

namespace Pumpkin.Contexts;

public partial class GstiOracleContext : DbContext
{
    public GstiOracleContext()
    {
    }

    public GstiOracleContext(DbContextOptions<GstiOracleContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bbambientesitem1> Bbambientesitem1 { get; set; }

    public virtual DbSet<Bbmstf500fm1> Bbmstf500fm1 { get; set; }

    public virtual DbSet<Descentralizadom1> Descentralizadom1 { get; set; }

    public virtual DbSet<Device2m1> Device2m1 { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseOracle(
                "Data Source=exa01-scan.servicos.bb.com.br/sp3e03hps003;User Id=ORACLEI1D0C;Password=qR47H1j5VQcU@;")
            .EnableSensitiveDataLogging();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("SMADMIN")
            .UseCollation("USING_NLS_COMP");

        modelBuilder.Entity<Bbambientesitem1>(entity =>
        {
            entity.HasKey(e => e.RecordKey).HasName("BBAMBIENTESITEM1089E8EC4");
        });

        modelBuilder.Entity<Descentralizadom1>(entity =>
        {
            entity.Property(e => e.Sinistrado).IsFixedLength();
            entity.Property(e => e.Temporario).IsFixedLength();
            entity.Property(e => e.Terceirizado).IsFixedLength();
        });

        modelBuilder.Entity<Device2m1>(entity =>
        {
            entity.Property(e => e.AllowSubscription).IsFixedLength();
            entity.Property(e => e.BaselineNoncompliant).IsFixedLength();
            entity.Property(e => e.BbEnvioCtl).IsFixedLength();
            entity.Property(e => e.BbMudancaProcessada).IsFixedLength();
            entity.Property(e => e.DataPrivacy).IsFixedLength();
            entity.Property(e => e.DeviceSeverity).IsFixedLength();
            entity.Property(e => e.DisasterCoverage).IsFixedLength();
            entity.Property(e => e.EventUpdated).IsFixedLength();
            entity.Property(e => e.IsDown).IsFixedLength();
            entity.Property(e => e.Itservice).IsFixedLength();
            entity.Property(e => e.Monitored).IsFixedLength();
            entity.Property(e => e.Nondevice).IsFixedLength();
            entity.Property(e => e.PendingChange).IsFixedLength();
            entity.Property(e => e.WmiScanned).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}