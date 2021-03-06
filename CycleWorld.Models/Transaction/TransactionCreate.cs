using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTransaction.Models
{
    public class TransactionCreate
    {
        [Required]
        [Display(Name = "Quantity Purchased")]
        public int ItemCount { get; set; }
    }
}
