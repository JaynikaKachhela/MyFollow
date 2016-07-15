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
        public string DateOfBirth { get; set; }
        public AddressInfo Address { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public ICollection<Followers> Followers { get; set; }
        public class AddressInfo
        {
            public string Street1 { get; set; }
            public string Street2 { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Country { get; set; }
            public long Pincode { get; set; }
            [DataType(DataType.PhoneNumber)]
            public string ContactNumber { get; set; }

        }
    }
}