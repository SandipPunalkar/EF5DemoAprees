using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore5WebApp.Core.Entities
{
  
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(255)]
        public string LastName { get; set; }

        [Required]
        public string EmailAddress { get; set; }

        //Navigation Property
        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
