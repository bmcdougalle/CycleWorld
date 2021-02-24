using System;
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
        public string PartName { get; set; }
        public string Manufacturer { get; set; }

        public string  ModelNumber { get; set; }

        public PartType TypeOfPart { get; set; }

        [MaxLength(8000)]
        public string Content { get; set; }



    }
}
