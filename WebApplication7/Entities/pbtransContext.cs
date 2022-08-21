using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication7.Entities
{
    public partial class pbtransContext : DbContext
    {
        public pbtransContext()
        {
        }

        public pbtransContext(DbContextOptions<pbtransContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Transaction> Transactions { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=root;database=pbtrans", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.30-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(e => new { e.Date, e.Brcode, e.Autonum })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("transactions");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Accno, "accno");

                entity.HasIndex(e => e.Autonum, "autonum");

                entity.HasIndex(e => e.Backenddate, "backenddate");

                entity.HasIndex(e => e.Brcode, "brcode");

                entity.HasIndex(e => e.Oldaccno, "oldaccno");

                entity.HasIndex(e => e.Ref, "ref");

                entity.HasIndex(e => e.Rvsl, "rvsl");

                entity.HasIndex(e => e.Trstat, "trstat");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Brcode)
                    .HasMaxLength(4)
                    .HasColumnName("brcode")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Autonum).HasColumnName("autonum");

                entity.Property(e => e.Accno)
                    .HasMaxLength(16)
                    .HasColumnName("accno");

                entity.Property(e => e.Amt)
                    .HasPrecision(18, 2)
                    .HasColumnName("amt");

                entity.Property(e => e.As400time).HasColumnName("as400time");

                entity.Property(e => e.Backenddate).HasColumnName("backenddate");

                entity.Property(e => e.CorrRef)
                    .HasMaxLength(20)
                    .HasColumnName("corr_ref")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Drcr)
                    .HasMaxLength(1)
                    .HasColumnName("drcr");

                entity.Property(e => e.Ecdate)
                    .HasMaxLength(10)
                    .HasColumnName("ecdate")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Ecuserid)
                    .HasMaxLength(20)
                    .HasColumnName("ecuserid")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ErrDes)
                    .HasMaxLength(200)
                    .HasColumnName("errDes");

                entity.Property(e => e.Newseqno)
                    .HasMaxLength(8)
                    .HasColumnName("newseqno")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Oldaccno)
                    .HasMaxLength(16)
                    .HasColumnName("oldaccno");

                entity.Property(e => e.Oldseqno)
                    .HasMaxLength(10)
                    .HasColumnName("oldseqno");

                entity.Property(e => e.ReceTime)
                    .HasMaxLength(20)
                    .HasColumnName("receTime");

                entity.Property(e => e.Ref)
                    .HasMaxLength(50)
                    .HasColumnName("ref");

                entity.Property(e => e.Ref1)
                    .HasMaxLength(50)
                    .HasColumnName("ref1");

                entity.Property(e => e.Ref2)
                    .HasMaxLength(50)
                    .HasColumnName("ref2");

                entity.Property(e => e.Rem1)
                    .HasMaxLength(300)
                    .HasColumnName("rem1");

                entity.Property(e => e.Rem2)
                    .HasMaxLength(20)
                    .HasColumnName("rem2");

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .HasColumnName("remark")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Response)
                    .HasMaxLength(200)
                    .HasColumnName("response");

                entity.Property(e => e.Retry).HasColumnName("retry");

                entity.Property(e => e.Rownum).HasColumnName("rownum");

                entity.Property(e => e.Rvsl)
                    .HasMaxLength(1)
                    .HasColumnName("rvsl")
                    .HasDefaultValueSql("'F'");

                entity.Property(e => e.Send)
                    .HasMaxLength(1)
                    .HasColumnName("send")
                    .HasDefaultValueSql("'F'");

                entity.Property(e => e.SendSms)
                    .HasMaxLength(200)
                    .HasColumnName("sendSMS")
                    .HasDefaultValueSql("'F'");

                entity.Property(e => e.SendTime)
                    .HasMaxLength(20)
                    .HasColumnName("sendTime");

                entity.Property(e => e.Seqno)
                    .HasMaxLength(10)
                    .HasColumnName("seqno");

                entity.Property(e => e.Time)
                    .HasMaxLength(20)
                    .HasColumnName("time");

                entity.Property(e => e.Trcode)
                    .HasMaxLength(4)
                    .HasColumnName("trcode");

                entity.Property(e => e.Trrefn)
                    .HasMaxLength(20)
                    .HasColumnName("trrefn")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Trstat)
                    .HasMaxLength(1)
                    .HasColumnName("trstat");

                entity.Property(e => e.Userid)
                    .HasMaxLength(10)
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Accno)
                    .HasName("PRIMARY");

                entity.ToTable("users");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Accno)
                    .HasMaxLength(20)
                    .HasColumnName("accno")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Active)
                    .HasMaxLength(1)
                    .HasColumnName("active")
                    .HasDefaultValueSql("'T'");

                entity.Property(e => e.Branch).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .HasColumnName("email");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Readermode)
                    .HasMaxLength(1)
                    .HasColumnName("readermode");

                entity.Property(e => e.Sendermode)
                    .HasMaxLength(1)
                    .HasColumnName("sendermode");

                entity.Property(e => e.Userid)
                    .HasMaxLength(20)
                    .HasColumnName("userid")
                    .HasDefaultValueSql("''");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
