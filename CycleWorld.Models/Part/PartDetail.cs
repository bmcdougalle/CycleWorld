using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleParts.Models
{
    public class PartDetail
    {
        public int PartId { get; set; }
        public string PartName { get; set; }
        public string ModelNumber { get; set; }

        public string Manufacturer { get; set; }

        public string PartType { get; set; }


        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}

