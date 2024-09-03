using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSample.ViewModels
{
     public class ProductViewModel
     {
        public int PruductId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int CategoryId { get; set; }
     }
}
