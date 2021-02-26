﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleParts.Models
{
    public enum PartType
    {
        Engine = 1,
        Frame,
        tank,
        Exhuast,
        DriveTrain,
        Fork,
        Seat
    }
    public class PartCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        
        [Display(Name ="Name of Part")]
        public string PartName { get; set; }
        
        [Display(Name = "Manufacturer")]
        public string Manufacturer { get; set; }

        [Display(Name = "Model Number")]
        public string  ModelNumber { get; set; }

        [Display(Name = "Type")]
        public PartType TypeOfPart { get; set; }

        [MaxLength(8000)]

        [Display(Name = "Description of Part")]
        public string Description { get; set; }
    }
}
