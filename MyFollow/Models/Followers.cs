using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFollow.Models
{
    public class Followers : CommonProperty
    {
        [ForeignKey("Id")]
        public User user { get; set; }
        [ForeignKey("Id")]
        public Product product { get; set; }
    }
}