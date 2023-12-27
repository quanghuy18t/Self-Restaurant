using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Manage.Models
{
    public partial class SelfRestaurant : DbContext
    {
        public SelfRestaurant()
            : base("name=SelfRestaurant")
        {
        }

        public virtual DbSet<BRANCH> BRANCHes { get; set; }
        public virtual DbSet<FOOD> FOODs { get; set; }
        public virtual DbSet<GIFTCARD> GIFTCARDs { get; set; }
        public virtual DbSet<ORDER> ORDERS { get; set; }
        public virtual DbSet<ROLE> ROLEs { get; set; }
        public virtual DbSet<SERVE> SERVEs { get; set; }
        public virtual DbSet<TABLE> TABLES { get; set; }
        public virtual DbSet<USER> USERS { get; set; }
        public virtual DbSet<ORDERDETAIL> ORDERDETAILs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FOOD>()
                .HasMany(e => e.ORDERDETAILs)
                .WithRequired(e => e.FOOD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FOOD>()
                .HasMany(e => e.SERVEs)
                .WithRequired(e => e.FOOD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ORDER>()
                .HasMany(e => e.ORDERDETAILs)
                .WithRequired(e => e.ORDER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ROLE>()
                .HasMany(e => e.USERS)
                .WithRequired(e => e.ROLE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TABLE>()
                .HasMany(e => e.ORDERS)
                .WithRequired(e => e.TABLE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.GIFTCARDs)
                .WithRequired(e => e.USER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.SERVEs)
                .WithRequired(e => e.USER)
                .WillCascadeOnDelete(false);
        }
    }
}
