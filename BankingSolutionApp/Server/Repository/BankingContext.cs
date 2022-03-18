using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Server.Repository
{
    public partial class BankingContext : DbContext
    {
        public BankingContext()
        {
        }

        public BankingContext(DbContextOptions<BankingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountFields> AccountFields { get; set; }
        public virtual DbSet<AdminDetails> AdminDetails { get; set; }
        public virtual DbSet<BankCredentials> BankCredentials { get; set; }
        public virtual DbSet<ModeOfTransaction> ModeOfTransaction { get; set; }
        public virtual DbSet<TransactionDetails> TransactionDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=SKCJPC;database=Banking;integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountFields>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__AccountF__A4AE64B899050B2D");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CredentialId).HasColumnName("CredentialID");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("emailID")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GrossAnnualIncome).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OccupationType)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Occupationdetails)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentAddressLine1)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentAddressLine2)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentCity)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentLandmark)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentState)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ResidentialAddressLine1)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ResidentialAddressLine2)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ResidentialCity)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ResidentialLandmark)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ResidentialState)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Sourceofincome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionReferenceId).HasColumnName("TransactionReferenceID");

                entity.HasOne(d => d.Credential)
                    .WithMany(p => p.AccountFields)
                    .HasForeignKey(d => d.CredentialId)
                    .HasConstraintName("fkey_credID");

                entity.HasOne(d => d.TransactionReference)
                    .WithMany(p => p.AccountFields)
                    .HasForeignKey(d => d.TransactionReferenceId)
                    .HasConstraintName("fkey_TransRefID");
            });

            modelBuilder.Entity<AdminDetails>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK__AdminDet__719FE4E8AD081DFB");

                entity.Property(e => e.AdminId)
                    .HasColumnName("AdminID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdminPassword)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BankCredentials>(entity =>
            {
                entity.HasKey(e => e.CredentialId)
                    .HasName("PK__BankCred__2C58F9EC971AE52C");

                entity.Property(e => e.CredentialId).HasColumnName("CredentialID");

                entity.Property(e => e.AccountBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreditCardExpiry).HasColumnType("date");

                entity.Property(e => e.DebitCardExpiry).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ModeOfTransaction>(entity =>
            {
                entity.HasKey(e => e.ModeId)
                    .HasName("PK__ModeOfTr__D83F75E4075C1575");

                entity.Property(e => e.ModeId)
                    .HasColumnName("ModeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaturityInstruction)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransactionDetails>(entity =>
            {
                entity.HasKey(e => e.TransactionReferenceId)
                    .HasName("PK__Transact__D119548170B2974D");

                entity.Property(e => e.TransactionReferenceId).HasColumnName("TransactionReferenceID");

                entity.Property(e => e.ModeId).HasColumnName("ModeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nickname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.Transactionamount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Mode)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.ModeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkey_modeID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
