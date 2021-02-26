using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleWorld.Models.User
{
    public class UserDetail
    {
        public int UserId { get; set; }

        [Display(Name = "Name of User")]
        public string Name { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
