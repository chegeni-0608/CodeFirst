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
    }
}
