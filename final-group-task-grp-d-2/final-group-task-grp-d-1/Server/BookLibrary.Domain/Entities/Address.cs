using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Domain.Entities
{
    public class Address
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required] 
        public string StreetName { get;set; }

        [Required]
        public string StreetNumber { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        public Guid UserId { get; set; }
        public AppUser User { get; set; }

    }
}
