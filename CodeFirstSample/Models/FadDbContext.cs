using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeFirstSample.Models
{
     public class FadDbContext:DbContext
    {
        public FadDbContext():base("name=FadDbConnectionString")
            {
            }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Master> Masters { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }

        //Fluent API
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                .Property(p => p.ProjectName)
                .IsRequired().HasMaxLength(128);

            modelBuilder.Entity<Project>()
                .Property(p => p.Description)
                .IsOptional().HasMaxLength(1024);

        }
    }
}
