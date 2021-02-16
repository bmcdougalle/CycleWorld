using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleWorld.Data
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Bio { get; set; }
        public List<Bike> ListOfBikes { get; set; }

        [ForeignKey(nameof(ShopId))]
        public int ShopId { get; set; }

    }
}
