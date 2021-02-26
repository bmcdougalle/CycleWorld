﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleParts.Models
{
    public class PartListItem
    {
        public int PartId { get; set; }
        
        [Display(Name = "Name of Part")]
        public string PartName { get; set; }

        [Display(Name = "Manufacturer")]
        public string  Manufacturer { get; set; }

        [Display(Name = "Model Number")]
        public string ModelNumber { get; set; }

        [Display(Name = "Type")]
        public string PartType { get; set; }
    }
}
