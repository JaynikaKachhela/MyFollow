using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFollow.Models
{
    public class User : CommonProperty
    {
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public Address Address { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public ICollection<Followers> Followers { get; set; }
    }
}