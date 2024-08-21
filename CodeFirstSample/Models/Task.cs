﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSample.Models
{
    public  class Task
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string TaskTitle { get; set; }
        public string TaskCode { get; set; }
        public string Runner { get; set; }
        public virtual Project Project { get; set; }
    }
}
