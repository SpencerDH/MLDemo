using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using MLDemo.Models;

namespace MLDemo.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        // Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<SalesDataSample> SalesDataSamples { get; set; }

        // Create the models
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            builder.Entity<SalesDataSample>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sales_data_sample");

                entity.Property(e => e.Addressline1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ADDRESSLINE1");

                entity.Property(e => e.Addressline2)
                    .HasMaxLength(50)
                    .HasColumnName("ADDRESSLINE2");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CITY");

                entity.Property(e => e.Contactfirstname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CONTACTFIRSTNAME");

                entity.Property(e => e.Contactlastname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CONTACTLASTNAME");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("COUNTRY");

                entity.Property(e => e.Customername)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CUSTOMERNAME");

                entity.Property(e => e.Dealsize)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DEALSIZE");

                entity.Property(e => e.MonthId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MONTH_ID");

                entity.Property(e => e.Msrp).HasColumnName("MSRP");

                entity.Property(e => e.Orderdate).HasColumnName("ORDERDATE");

                entity.Property(e => e.Orderlinenumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ORDERLINENUMBER");

                entity.Property(e => e.Ordernumber).HasColumnName("ORDERNUMBER");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Postalcode)
                    .HasMaxLength(50)
                    .HasColumnName("POSTALCODE");

                entity.Property(e => e.Priceeach).HasColumnName("PRICEEACH");

                entity.Property(e => e.Productcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PRODUCTCODE");

                entity.Property(e => e.Productline)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PRODUCTLINE");

                entity.Property(e => e.QtrId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("QTR_ID");

                entity.Property(e => e.Quantityordered).HasColumnName("QUANTITYORDERED");

                entity.Property(e => e.Sales).HasColumnName("SALES");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .HasColumnName("STATE");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Territory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TERRITORY");

                entity.Property(e => e.YearId).HasColumnName("YEAR_ID");
            });

            base.OnModelCreating(builder);
        }

    }
}
