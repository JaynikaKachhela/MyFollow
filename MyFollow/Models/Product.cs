using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFollow.Models
{
    public class Product : CommonProperty
    {
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public ProductType Type { get; set; }
        [DataType(DataType.Url)]
        public string HomepageUrl { get; set; }
        [DataType(DataType.Url)]
        public string PlaystoreUrl { get; set; }
        [DataType(DataType.Url)]
        public string AppstoreUrl { get; set; }
        public int ProductOwnerId { get; set; }
        [ForeignKey("Id")]
        public ProductOwner ProductOwner { get; set; }
        public ICollection<ProductUpdate> ProductUpdates { get; set; }
        public ICollection<Followers> Followers { get; set; }
    }
    public enum ProductType
    {
        Mobile = 1, web = 2, IoT = 3, Platform = 4
    }
}