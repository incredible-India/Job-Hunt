using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobHunt_Models.User
{
    public class NewUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
      
        public string FirstName { get; set; }
      
        public string? LastName { get; set; }
        public int Age { get; set; }
        [Required]
        public string PhoneNo { get; set; }
        public string? AlternatePhoneNo { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Gender { get; set; }

    }
}
