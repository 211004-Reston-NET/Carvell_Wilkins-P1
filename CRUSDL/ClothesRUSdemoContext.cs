using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CRUSModels;

#nullable disable

namespace CRUSDL
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
        public virtual DbSet<TestTable> TestTables { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        //public virtual DbSet<LineItem> LineItems { get; set; }
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
                entity.ToTable("LineItem");

                entity.Property(e => e.LineItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("LineItem_ID");

                // entity.Property(e => e.OrderId).HasColumnName("Order_ID");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                // entity.HasOne(d => d.OrderPlacement)
                //     .WithMany(p => p.LineItems)
                //     .HasForeignKey(d => d.OrderId)
                //     .HasConstraintName("FK__LineItem__Order___14270015");

                // entity.HasOne(d => d.Product)
                //     .WithMany(p => p.LineItems)
                //     .HasForeignKey(d => d.ProductId)
                //     .HasConstraintName("FK__LineItem__Produc__00200768");
            });

            modelBuilder.Entity<OrderPlacement>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__OrderPla__464665E1B7D4693B");

                entity.ToTable("OrderPlacement");

                entity.Property(e => e.OrderId).HasColumnName("order_ID");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.Property(e => e.StoreFrontId).HasColumnName("StoreFront_ID");
                /*Changed Total price to Price. doing this so that orderplacement could show the price*/


                entity.Property(e => e.Price).HasColumnName("Price");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.orderPlacements)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasConstraintName("FK__OrderPlac__Custo__10566F31");

              /*changing the below to see if I can link the price of product to order placement 11/16*/   
                entity.HasOne(d => d.Product)
                     .WithMany(p => p.OrderPlacements)
                     .HasForeignKey(d => d.Price)
                     .HasForeignKey(d => d.ProductId)
                     .HasConstraintName("FK__OrderPlac__Produ__0F624AF8");

                entity.HasOne(d => d.StoreFront)
                    .WithMany(p => p.OrderPlacement)
                    .HasForeignKey(d => d.StoreFrontId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasConstraintName("FK__OrderPlac__Store__0E6E26BF");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                //entity.Property(e => e.LineItemId).HasColumnName("LineItem_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreFrontId).HasColumnName("StoreFront_ID");

                entity.HasOne(d => d.StoreFront)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.StoreFrontId)
                    .OnDelete(DeleteBehavior.NoAction)
                    .HasConstraintName("FK__Product__StoreFr__114A936A");
            });

            modelBuilder.Entity<StoreFront>(entity =>
            {
                entity.ToTable("StoreFront");

                entity.Property(e => e.StoreFrontId).HasColumnName("StoreFront_ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                // entity.Property(e => e.ListOfOrders)
                //     .HasMaxLength(100)
                //     .IsUnicode(false)
                //     .HasColumnName("List_of_Orders");

                // entity.Property(e => e.ListOfProducts)
                //     .HasMaxLength(100)
                //     .IsUnicode(false)
                //     .HasColumnName("List_of_Products");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
