using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session06.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(64)]
        public string FirstName { get; set; }
        [MaxLength(128)]
        public string LastName { get; set; }
        public int? Score { get; set; }
    }
}
