namespace comp2007_s2016_asgn_2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MenuItemModel : DbContext
    {
        public MenuItemModel()
            : base("name=MenuItemConnection")
        {
        }

        public virtual DbSet<MenuItems> MenuItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuItems>()
                .Property(e => e.Price)
                .HasPrecision(5, 2);

            modelBuilder.Entity<MenuItems>()
                .Property(e => e.ImageName)
                .IsUnicode(false);
        }
    }
}
