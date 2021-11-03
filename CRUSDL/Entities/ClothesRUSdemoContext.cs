using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CRUSDL.Entities
{
    public partial class ClothesRUSdemoContext : DbContext
    {
        public ClothesRUSdemoContext()
        {
        }

        public ClothesRUSdemoContext(DbContextOptions<ClothesRUSdemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<LineItem> LineItems { get; set; }
        public virtual DbSet<OrderPlacement> OrderPlacements { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<StoreFront> StoreFronts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LineItem>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__LineItem__9833FF92B126F269");

                entity.Property(e => e.ProductId).HasColumnName("Product_id");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Product)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderPlacement>(entity =>
            {
                entity.ToTable("OrderPlacement");

                entity.Property(e => e.OrderPlacementId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("OrderPlacement_ID");

                entity.Property(e => e.Decription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.Property(e => e.StoreFrontName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StoreFront_Name");

                entity.HasOne(d => d.OrderPlacementNavigation)
                    .WithOne(p => p.OrderPlacement)
                    .HasForeignKey<OrderPlacement>(d => d.OrderPlacementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderPlac__Order__6FE99F9F");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Brand)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClothingType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Clothing_Type");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");
            });

            modelBuilder.Entity<StoreFront>(entity =>
            {
                entity.ToTable("StoreFront");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
