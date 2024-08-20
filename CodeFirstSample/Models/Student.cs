using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSample.Models
{
    [Table("MyStudent")]
    public class Student
    {
        [Key]
        public int  StudentId { get; set; }
        [Required]
        [MaxLength(32)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength]
        public string LastName { get; set; }
        public string Mobile { get; set; }
    }
}
