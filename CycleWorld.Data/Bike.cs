using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleWorld.Data
{
    public class Bike
    {
        [Key]
        public int BikeId { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Make { get; set; }


    }
}
