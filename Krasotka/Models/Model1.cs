using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Krasotka.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderProduct> OrderProduct { get; set; }
        public virtual DbSet<PickupPoint> PickupPoint { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductName> ProductName { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
