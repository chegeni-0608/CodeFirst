using CodeFirstSample.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Session06.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=CsharpModel")
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Master> Masters { get; set; }  


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
