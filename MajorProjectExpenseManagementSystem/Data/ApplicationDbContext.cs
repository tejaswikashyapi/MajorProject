using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MajorProjectExpenseManagementSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MajorProjectExpenseManagementSystem.Data
{
    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BudgetCategories> BudgetCategories { get; set; }
        public virtual DbSet<Budgets> Budgets { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Expenses> Expenses { get; set; }
        public virtual DbSet<Payers> Payers { get; set; }
        public virtual DbSet<UserCategories> UserCategories { get; set; }
        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MajorProject;Integrated Security=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        modelBuilder.Entity<BudgetCategories>(entity =>
        //        {
        //            entity.HasNoKey();

        //            entity.ToTable("budgetCategories");

        //            entity.Property(e => e.Amount).HasColumnName("amount");

        //            entity.Property(e => e.BudgetsId).HasColumnName("budgets_id");

        //            entity.Property(e => e.CategoryId).HasColumnName("category_id");

        //            entity.HasOne(d => d.Budgets)
        //                .WithMany()
        //                .HasForeignKey(d => d.BudgetsId)
        //                .OnDelete(DeleteBehavior.ClientSetNull)
        //                .HasConstraintName("budgetCategories_budgets_id_fkey");

        //            entity.HasOne(d => d.Category)
        //                .WithMany()
        //                .HasForeignKey(d => d.CategoryId)
        //                .OnDelete(DeleteBehavior.ClientSetNull)
        //                .HasConstraintName("budgetCategories_category_id_fkey");
        //        });

        //        modelBuilder.Entity<Budgets>(entity =>
        //        {
        //            entity.ToTable("budgets");

        //            entity.Property(e => e.Id)
        //                .HasColumnName("id")
        //                .ValueGeneratedNever();

        //            entity.Property(e => e.Amount).HasColumnName("amount");

        //            entity.Property(e => e.Name)
        //                .IsRequired()
        //                .HasColumnName("name")
        //                .IsUnicode(false);

        //            entity.Property(e => e.UserId).HasColumnName("user_id");

        //            entity.HasOne(d => d.User)
        //                .WithMany(p => p.Budgets)
        //                .HasForeignKey(d => d.UserId)
        //                .OnDelete(DeleteBehavior.ClientSetNull)
        //                .HasConstraintName("budgets_user_id_fkey");
        //        });

        //        modelBuilder.Entity<Categories>(entity =>
        //        {
        //            entity.ToTable("categories");

        //            entity.Property(e => e.Id)
        //                .HasColumnName("id")
        //                .ValueGeneratedNever();

        //            entity.Property(e => e.Name)
        //                .IsRequired()
        //                .HasColumnName("name")
        //                .IsUnicode(false);
        //        });

        //        modelBuilder.Entity<Expenses>(entity =>
        //        {
        //            entity.ToTable("expenses");

        //            entity.Property(e => e.Id)
        //                .HasColumnName("id")
        //                .ValueGeneratedNever();

        //            entity.Property(e => e.Amount).HasColumnName("amount");

        //            entity.Property(e => e.Category)
        //                .IsRequired()
        //                .HasColumnName("category")
        //                .IsUnicode(false);

        //            entity.Property(e => e.Description)
        //                .IsRequired()
        //                .HasColumnName("description")
        //                .IsUnicode(false);

        //            entity.Property(e => e.Expensedate)
        //                .IsRequired()
        //                .HasColumnName("expensedate")
        //                .IsUnicode(false);

        //            entity.Property(e => e.Payer)
        //                .IsRequired()
        //                .HasColumnName("payer")
        //                .IsUnicode(false);

        //            entity.Property(e => e.Submittime)
        //                .IsRequired()
        //                .HasColumnName("submittime")
        //                .IsUnicode(false);

        //            entity.Property(e => e.UserId).HasColumnName("user_id");
        //        });

        //        modelBuilder.Entity<Payers>(entity =>
        //        {
        //            entity.HasNoKey();

        //            entity.ToTable("payers");

        //            entity.Property(e => e.Name)
        //                .IsRequired()
        //                .HasColumnName("name")
        //                .IsUnicode(false);

        //            entity.Property(e => e.UserId).HasColumnName("user_id");

        //            entity.HasOne(d => d.User)
        //                .WithMany()
        //                .HasForeignKey(d => d.UserId)
        //                .OnDelete(DeleteBehavior.ClientSetNull)
        //                .HasConstraintName("payers_user_id_fkey");
        //        });

        //        modelBuilder.Entity<UserCategories>(entity =>
        //        {
        //            entity.HasNoKey();

        //            entity.ToTable("userCategories");

        //            entity.Property(e => e.CategoryId).HasColumnName("category_id");

        //            entity.Property(e => e.UserId).HasColumnName("user_id");

        //            entity.HasOne(d => d.Category)
        //                .WithMany()
        //                .HasForeignKey(d => d.CategoryId)
        //                .OnDelete(DeleteBehavior.ClientSetNull)
        //                .HasConstraintName("userCategories_category_id_fkey");

        //            entity.HasOne(d => d.User)
        //                .WithMany()
        //                .HasForeignKey(d => d.UserId)
        //                .OnDelete(DeleteBehavior.ClientSetNull)
        //                .HasConstraintName("userCategories_user_id_fkey");
        //        });

        //        modelBuilder.Entity<ApplicationUser>(entity =>
        //        {
        //            entity.ToTable("users");

        //            entity.Property(e => e.Id)
        //                .HasColumnName("id")
        //                .ValueGeneratedNever();



        //            entity.Property(e => e.Income)
        //                .HasColumnName("income")
        //                .HasDefaultValueSql("((60000.00))");



        //            entity.Property(e => e.Registerdate)
        //                .IsRequired()
        //                .HasColumnName("registerdate")
        //                .IsUnicode(false);

        //        });

        //        OnModelCreatingPartial(modelBuilder);
        //    }

        //    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        //}
    }
}
