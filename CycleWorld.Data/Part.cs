using CycleShops.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleParts.Data
{
    public class Part
    {
        [Key]
        public int PartId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string Title { get; set; }

    }
}

