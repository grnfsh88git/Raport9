using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Raport9.Models;

public partial class RaportyContext : DbContext
{
    public RaportyContext()
    {
    }

    public RaportyContext(DbContextOptions<RaportyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Arttext> Arttexts { get; set; }

    public virtual DbSet<Artykul> Artykuls { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<Automatyk> Automatyks { get; set; }

    public virtual DbSet<Jeleniaplast> Jeleniaplasts { get; set; }

    public virtual DbSet<ListaWtryskarek> ListaWtryskareks { get; set; }

    public virtual DbSet<ListaWtryskarek4> ListaWtryskarek4s { get; set; }

    public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }

    public virtual DbSet<Prezentacja> Prezentacjas { get; set; }

    public virtual DbSet<Projekty> Projekties { get; set; }

    public virtual DbSet<Przezbrojenium> Przezbrojenia { get; set; }

    public virtual DbSet<Table1> Table1s { get; set; }

    public virtual DbSet<Typ> Typs { get; set; }

    public virtual DbSet<_1Art> _1Arts { get; set; }

    public virtual DbSet<_1Glowna> _1Glownas { get; set; }

    public virtual DbSet<_1Typ> _1Typs { get; set; }

    public virtual DbSet<_1Zmiana> _1Zmianas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-H86SVD3;Initial Catalog=raporty;User ID=sa;Password=zx;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Arttext>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("arttext");

            entity.Property(e => e.Art)
                .IsUnicode(false)
                .HasColumnName("art");
            entity.Property(e => e.Arttext1)
                .HasColumnType("text")
                .HasColumnName("arttext");
        });

        modelBuilder.Entity<Artykul>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_art");

            entity.ToTable("Artykul");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Art)
                .HasMaxLength(255)
                .HasColumnName("art");
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetRoles");

            entity.HasIndex(e => e.Name, "RoleNameIndex").IsUnique();

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUsers");

            entity.HasIndex(e => e.UserName, "UserNameIndex").IsUnique();

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("PK_dbo.AspNetUserRoles");
                        j.ToTable("AspNetUserRoles");
                        j.HasIndex(new[] { "RoleId" }, "IX_RoleId");
                        j.HasIndex(new[] { "UserId" }, "IX_UserId");
                        j.IndexerProperty<string>("UserId").HasMaxLength(128);
                        j.IndexerProperty<string>("RoleId").HasMaxLength(128);
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUserClaims");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId }).HasName("PK_dbo.AspNetUserLogins");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<Automatyk>(entity =>
        {
            entity.ToTable("automatyk");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Automatyk1)
                .HasMaxLength(100)
                .HasColumnName("automatyk");
        });

        modelBuilder.Entity<Jeleniaplast>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("jeleniaplast");

            entity.Property(e => e.F13).HasMaxLength(255);
            entity.Property(e => e.F3).HasMaxLength(255);
            entity.Property(e => e.F4).HasMaxLength(255);
            entity.Property(e => e.F5).HasMaxLength(255);
            entity.Property(e => e.F7).HasMaxLength(255);
            entity.Property(e => e.Kiedy)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("kiedy");
            entity.Property(e => e.Kto)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("kto");
            entity.Property(e => e.Zmiana).HasColumnName("zmiana");
        });

        modelBuilder.Entity<ListaWtryskarek>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Table_1");

            entity.ToTable("lista_wtryskarek");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nr).HasColumnName("nr");
            entity.Property(e => e.Robot)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("robot");
            entity.Property(e => e.Wtryskarka)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("wtryskarka");
        });

        modelBuilder.Entity<ListaWtryskarek4>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_lista_wtryskarek");

            entity.ToTable("lista_wtryskarek4");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nr).HasColumnName("nr");
            entity.Property(e => e.Robot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ROBOT");
            entity.Property(e => e.Wtryskarka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WTRYSKARKA");
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_dbo.__MigrationHistory");

            entity.ToTable("__MigrationHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ContextKey).HasMaxLength(300);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<Prezentacja>(entity =>
        {
            entity.ToTable("prezentacja");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Czaspracy)
                .HasColumnType("datetime")
                .HasColumnName("czaspracy");
            entity.Property(e => e.Czasprestoju)
                .HasMaxLength(255)
                .HasColumnName("czasprestoju");
            entity.Property(e => e.Data)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("data");
            entity.Property(e => e.Kiedy)
                .HasMaxLength(100)
                .HasColumnName("kiedy");
            entity.Property(e => e.Kto)
                .HasMaxLength(255)
                .HasColumnName("kto");
            entity.Property(e => e.Miesiac).HasColumnName("miesiac");
            entity.Property(e => e.NrArt)
                .HasMaxLength(255)
                .HasColumnName("nr art");
            entity.Property(e => e.NrWtr).HasColumnName("nr wtr");
            entity.Property(e => e.Opis)
                .HasColumnType("text")
                .HasColumnName("opis");
            entity.Property(e => e.Robot)
                .HasMaxLength(255)
                .HasColumnName("robot");
            entity.Property(e => e.Rok).HasColumnName("rok");
            entity.Property(e => e.Typ)
                .HasMaxLength(255)
                .HasColumnName("typ");
            entity.Property(e => e.Wtr)
                .HasMaxLength(255)
                .HasColumnName("wtr");
            entity.Property(e => e.Zmiana).HasColumnName("zmiana");
        });

        modelBuilder.Entity<Projekty>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("projekty");

            entity.Property(e => e.Projekty1)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("projekty");
        });

        modelBuilder.Entity<Przezbrojenium>(entity =>
        {
            entity.ToTable("przezbrojenia");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Artykuł)
                .HasMaxLength(255)
                .HasColumnName("Artykuł ");
            entity.Property(e => e.Automatyk).HasMaxLength(255);
            entity.Property(e => e.Data)
                .HasColumnType("datetime")
                .HasColumnName("DATA");
            entity.Property(e => e.DemontażD)
                .HasMaxLength(255)
                .HasColumnName("Demontaż_- D");
            entity.Property(e => e.KrokowanieK)
                .HasMaxLength(255)
                .HasColumnName("Krokowanie_- K");
            entity.Property(e => e.MontażM)
                .HasMaxLength(255)
                .HasColumnName("Montaż_- M");
            entity.Property(e => e.StartS)
                .HasMaxLength(255)
                .HasColumnName("Start_- S");
            entity.Property(e => e.Uwagi).HasMaxLength(255);
            entity.Property(e => e.Wykonane).HasMaxLength(255);
            entity.Property(e => e.Zmiana).HasColumnName("Zmiana ");
        });

        modelBuilder.Entity<Table1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Table_1_1");

            entity.ToTable("Table_1");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IdGlowna).HasColumnName("ID_glowna");
            entity.Property(e => e.Opis)
                .HasColumnType("text")
                .HasColumnName("opis");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Table1)
                .HasForeignKey<Table1>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Table_1_1_glowna");
        });

        modelBuilder.Entity<Typ>(entity =>
        {
            entity.HasKey(e => e.IdTyp);

            entity.ToTable("typ");

            entity.Property(e => e.IdTyp).HasColumnName("ID_typ");
            entity.Property(e => e.Typ1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("typ");
        });

        modelBuilder.Entity<_1Art>(entity =>
        {
            entity.HasKey(e => e.IdArt);

            entity.ToTable("1_art");

            entity.Property(e => e.IdArt).HasColumnName("ID_art");
            entity.Property(e => e.NrArt)
                .HasMaxLength(255)
                .IsFixedLength()
                .HasColumnName("nr_art");
        });

        modelBuilder.Entity<_1Glowna>(entity =>
        {
            entity.ToTable("1_glowna");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IdTyp)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ID_typ");
            entity.Property(e => e.Imie)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("imie");
            entity.Property(e => e.Nazwisko)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("nazwisko");
            entity.Property(e => e.NrArt)
                .HasMaxLength(50)
                .HasColumnName("nr art");
            entity.Property(e => e.Typ)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("typ");
            entity.Property(e => e.Wtryskarka).HasColumnName("wtryskarka");
            entity.Property(e => e.Zadanie)
                .HasColumnType("text")
                .HasColumnName("zadanie");
            entity.Property(e => e.Zmiana).HasColumnName("zmiana");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p._1Glowna)
                .HasForeignKey<_1Glowna>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_1_glowna_1_art");
        });

        modelBuilder.Entity<_1Typ>(entity =>
        {
            entity.HasKey(e => e.IdTyp);

            entity.ToTable("1_typ");

            entity.Property(e => e.IdTyp).HasColumnName("ID_typ");
            entity.Property(e => e.Typ)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("typ");
        });

        modelBuilder.Entity<_1Zmiana>(entity =>
        {
            entity.HasKey(e => e.IdZmiana);

            entity.ToTable("1_zmiana");

            entity.Property(e => e.IdZmiana).HasColumnName("ID_zmiana");
            entity.Property(e => e.Zmiana).HasColumnName("zmiana");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
