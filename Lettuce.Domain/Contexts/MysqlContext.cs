using System;
using System.Collections.Generic;
using Lettuce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace Lettuce.Domain.Contexts;

public partial class MysqlContext : DbContext
{
    public MysqlContext()
    {
    }

    public MysqlContext(DbContextOptions<MysqlContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Pumpkim> Pumpkim { get; set; }

    public virtual DbSet<Warrior> Warrior { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=55003;database=amorim;uid=root;pwd=brasilia12", Microsoft.EntityFrameworkCore.ServerVersion.Parse("9.0.1-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
