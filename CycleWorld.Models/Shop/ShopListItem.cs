using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleShops.Models
{
    public class ShopListItem
    {
        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public string Services { get; set; }
        public string Location { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}