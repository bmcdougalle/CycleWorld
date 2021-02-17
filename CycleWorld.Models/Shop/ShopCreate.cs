using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleShops.Models
{
    public class ShopCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string ShopName { get; set; }

        [MaxLength(8000)]
        public string Services { get; set; }

        public string Location { get; set; }

        public int PartId { get; set; }
    }
}