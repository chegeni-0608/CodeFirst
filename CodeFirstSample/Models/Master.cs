using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSample.Models
{
    public class Master
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(64)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(64)]

        public string LastName { get; set; }
        [MaxLength(11)]
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

    }
}
