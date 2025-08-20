using System;
using System.Collections.Generic;
using BiosoftPlusFaceScanAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BiosoftPlusFaceScanAPI.Data;

public partial class AppDb : DbContext
{
    public AppDb(DbContextOptions<AppDb> options)
        : base(options)
    {
    }

    public virtual DbSet<TEMPIMPORT> TEMPIMPORTs { get; set; }

    public virtual DbSet<EmployeeScanTimeVIEW> EmployeeScanTimeVIEW { get; set; } = null!;


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeeScanTimeVIEW>(entity =>
        {
            entity.HasKey(e => new { e.Code });  // กำหนดคีย์เอง
            entity.ToView("EmployeeScanTimeVIEW", "dbo");
        });

        modelBuilder.Entity<TEMPIMPORT>(entity =>
        {
            entity.HasKey(e => new { e.Employee, e.dt, e.Times, e.COMID }).HasName("PK_HRM@TempImport");

            entity.ToTable("TEMPIMPORT");

            entity.Property(e => e.Employee)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Thai_BIN");
            entity.Property(e => e.dt).HasColumnType("datetime");
            entity.Property(e => e.Times)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Thai_BIN");
            entity.Property(e => e.COMID)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Thai_BIN");
            entity.Property(e => e.CreateBy).HasMaxLength(30);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentNo).HasMaxLength(200);
            entity.Property(e => e.IO)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Thai_BIN");
            entity.Property(e => e.ModifyBy).HasMaxLength(30);
            entity.Property(e => e.ModifyDate).HasColumnType("datetime");
            entity.Property(e => e.OverDay).HasDefaultValue(false);
            entity.Property(e => e.Shift)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Thai_BIN");
            entity.Property(e => e.SourceType).HasMaxLength(200);
            entity.Property(e => e.Status).HasMaxLength(200);
            entity.Property(e => e.Terminal)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("Thai_BIN");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
