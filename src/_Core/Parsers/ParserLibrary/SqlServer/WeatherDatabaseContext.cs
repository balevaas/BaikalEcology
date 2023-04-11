using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ParserLibrary.SqlServer;

public partial class WeatherDatabaseContext : DbContext
{
    public WeatherDatabaseContext()
    {
    }

    public WeatherDatabaseContext(DbContextOptions<WeatherDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Datum> Data { get; set; }

    public virtual DbSet<Station> Stations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ANASTASIA-ПК\\SQLEXPRESS;Initial Catalog=WeatherDatabase;Integrated Security=True;encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Datum>(entity =>
        {
            entity.HasKey(e => new { e.Station, e.Date }).HasName("PK__Data__B7D3404313521796");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Pressure).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.SnowHeight).HasColumnName("Snow_Height");
            entity.Property(e => e.Temperature).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.WindDirection)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("Wind_Direction");
            entity.Property(e => e.WindSpeed).HasColumnName("Wind_Speed");

            entity.HasOne(d => d.StationNavigation).WithMany(p => p.Data)
                .HasForeignKey(d => d.Station)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Data__Station__1273C1CD");
        });

        modelBuilder.Entity<Station>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Station__3214EC27A40DEE4B");

            entity.ToTable("Station");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Height).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Location).IsRequired();
            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
