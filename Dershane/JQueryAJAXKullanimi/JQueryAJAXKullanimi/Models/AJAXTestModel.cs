namespace JQueryAJAXKullanimi.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AJAXTestModel : DbContext
    {
        public AJAXTestModel()
            : base("name=AJAXTestModel")
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<County> Counties { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
