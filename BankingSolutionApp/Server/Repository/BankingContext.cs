﻿using System;
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
        public virtual DbSet<CreditCardCredentials> CreditCardCredentials { get; set; }
        public virtual DbSet<DebitCardCredentials> DebitCardCredentials { get; set; }
        public virtual DbSet<ModeOfTransaction> ModeOfTransaction { get; set; }
        public virtual DbSet<NetBankingCredentials> NetBankingCredentials { get; set; }
        public virtual DbSet<TransactionDetails> TransactionDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=SKCJPC;database=Banking;integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountFields>(entity =>
            {
                entity.HasKey(e => e.AccountNumber)
                    .HasName("PK__AccountF__BE2ACD6EF8089836");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AadhaarCardNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

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

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileno)
                    .IsRequired()
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

                entity.Property(e => e.PermanentPincode)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentState)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceId)
                    .HasColumnName("ReferenceID")
                    .ValueGeneratedOnAdd();

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

                entity.Property(e => e.ResidentialPincode)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ResidentialState)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Sourceofincome).HasColumnType("money");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.CreditCardNumberNavigation)
                    .WithMany(p => p.AccountFields)
                    .HasForeignKey(d => d.CreditCardNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkey_CreditcardAccDetails");

                entity.HasOne(d => d.DebitCardNumberNavigation)
                    .WithMany(p => p.AccountFields)
                    .HasForeignKey(d => d.DebitCardNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkey_DebitcardAccDetails");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AccountFields)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkey_UserIDAccDetails");
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

            modelBuilder.Entity<CreditCardCredentials>(entity =>
            {
                entity.HasKey(e => e.CreditCardNumber)
                    .HasName("PK__CreditCa__315DB924005F4CE5");

                entity.Property(e => e.CreditCardNumber).ValueGeneratedNever();

                entity.Property(e => e.CreditCardCvv).HasColumnName("CreditCardCVV");

                entity.Property(e => e.CreditCardExpiry).HasColumnType("date");
            });

            modelBuilder.Entity<DebitCardCredentials>(entity =>
            {
                entity.HasKey(e => e.DebitCardNumber)
                    .HasName("PK__DebitCar__136D27858053C5B5");

                entity.Property(e => e.DebitCardNumber).ValueGeneratedNever();

                entity.Property(e => e.DebitCardCvv).HasColumnName("DebitCardCVV");

                entity.Property(e => e.DebitCardExpiry).HasColumnType("date");
            });

            modelBuilder.Entity<ModeOfTransaction>(entity =>
            {
                entity.HasKey(e => e.ModeId)
                    .HasName("PK__ModeOfTr__D83F75E4075C1575");

                entity.Property(e => e.ModeId)
                    .HasColumnName("ModeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaturityInstruction)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NetBankingCredentials>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__NetBanki__1788CCACEDD9F6C3");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccountNumberNavigation)
                    .WithMany(p => p.NetBankingCredentials)
                    .HasForeignKey(d => d.AccountNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkey_Net_Accno");
            });

            modelBuilder.Entity<TransactionDetails>(entity =>
            {
                entity.HasKey(e => e.TransactionReferenceId)
                    .HasName("PK__Transact__D119548104773AFC");

                entity.Property(e => e.TransactionReferenceId)
                    .HasColumnName("TransactionReferenceID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModeId).HasColumnName("ModeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nickname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientAccountNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.Transactionamount).HasColumnType("money");

                entity.HasOne(d => d.AccountNumberNavigation)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.AccountNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkey_Accno");

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