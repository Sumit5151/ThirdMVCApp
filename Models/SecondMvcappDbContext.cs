using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ThirdMVCApp.Models;

public partial class SecondMvcappDbContext : DbContext
{
    public SecondMvcappDbContext()
    {
    }

    public SecondMvcappDbContext(DbContextOptions<SecondMvcappDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("server=SUMIT; database=SecondMVCAppDB; trusted_connection=true; trustservercertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC07056D6130");

            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
