using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFollow.Models
{
    public class ProductUpdate : CommonProperty
    {
        [DataType(DataType.MultilineText)]
        public string Introduction { get; set; }
        [DataType(DataType.MultilineText)]
        public string Detail { get; set; }
        [DataType(DataType.MultilineText)]
        public string Media { get; set; }
        [ForeignKey("Id")]
        public Product product { get; set; }
    }
}