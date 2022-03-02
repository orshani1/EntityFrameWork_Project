using DigitalATM.DB.GenericRepository;
using DigitalATM.DB.Interfaces;
using DigitalATM.DB.Modelss.AccountModel;
using DigitalATM.DB.Modelss.ClientModel;
using DigitalATM.DB.Modelss.CreditCardModel;
using DigitalATM.DB.Modelss.Deposits;
using DigitalATM.DB.Modelss.Loans;
using DigitalATM.DB.Modelss.Savings;
using DigitalATM.DB.Modelss.Withdraw;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace DigitalATM.DB.Modelss
{
    public partial class DigitalATMContext : DbContext
    {


        public DigitalATMContext()
        {


        }

        public DigitalATMContext(DbContextOptions<DigitalATMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<AccountAction> AccountActions { get; set; } = null!;
        public virtual DbSet<Admin> Admins { get; set; } = null!;
        public virtual DbSet<Bank> Banks { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<CreditCard> CreditCards { get; set; } = null!;
        public virtual DbSet<Deposit> Deposits { get; set; } = null!;
        public virtual DbSet<Loan> Loans { get; set; } = null!;
        public virtual DbSet<Saving> Savings { get; set; } = null!;
        public virtual DbSet<Transfer> Transfers { get; set; } = null!;
        public virtual DbSet<WithDraw> WithDraws { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=DigitalATM;Integrated Security=True");


                



            }

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_Bank");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_Clients");
            });

            modelBuilder.Entity<AccountAction>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountActions)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountActions_Account");
            });

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("Bank");

                entity.Property(e => e.BankName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.Adress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CreditCard>(entity =>
            {
                entity.HasKey(e => e.CardId);

                entity.Property(e => e.CardCvv).HasColumnName("CardCVV");

                entity.Property(e => e.CardExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.CardHolder)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CreditCards)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_CreditCards_Account1");
            });

            modelBuilder.Entity<Deposit>(entity =>
            {
                entity.ToTable("Deposit");

                entity.Property(e => e.DepositDate).HasColumnType("datetime");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Deposits)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Deposit_Account");
            });

            modelBuilder.Entity<Loan>(entity =>
            {
                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Loans)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Loans_Account");
            });

            modelBuilder.Entity<Saving>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SaveName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Savings)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Savings_Account");
            });

            modelBuilder.Entity<Transfer>(entity =>
            {
                entity.ToTable("Transfer");

                entity.Property(e => e.TransferDate).HasColumnType("datetime");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Transfers)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transfer_Account");
            });

            modelBuilder.Entity<WithDraw>(entity =>
            {
                entity.ToTable("WithDraw");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.WithdrawDate).HasColumnType("datetime");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.WithDraws)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WithDraw_Account");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
       
    }

}
