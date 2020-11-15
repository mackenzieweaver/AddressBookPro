using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBookPro.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }

        [Required]
        [Display(Name = "Your Name")]
        public string Author { get; set; }

        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
