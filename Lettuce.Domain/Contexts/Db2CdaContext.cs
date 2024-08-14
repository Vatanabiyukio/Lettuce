using Microsoft.EntityFrameworkCore;
using Pumpkin.Entities;

namespace Pumpkin.Contexts;

public class Db2CdaContext : DbContext
{
    protected Db2CdaContext()
    {
    }

    public Db2CdaContext(DbContextOptions<Db2CdaContext> options) : base(options)
    {
    }

    public DbSet<EvtPvtdEvt> EvtPvtdEvts { get; set; }
    public DbSet<PvtdEvt> PvtdEvts { get; set; }
    public DbSet<CdUorPvtd> CdUorPvtds { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }
}