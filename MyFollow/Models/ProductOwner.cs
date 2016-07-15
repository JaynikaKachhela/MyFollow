using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFollow.Models
{
    public class ProductOwner : User
    {
        public string CompanyName { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public int FoundedYear { get; set; }
        [DataType(DataType.Url)]
        public string WebsiteUrl { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}