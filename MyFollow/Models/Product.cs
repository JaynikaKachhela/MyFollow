﻿using System;
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
        public string HomepageUrl { get; set; }
        public string PlaystoreUrl { get; set; }
        public string AppstoreUrl { get; set; }
        [ForeignKey("Id")]
        public ProductOwner productOwner { get; set; }
        public ICollection<ProductUpdate> ProductUpdates { get; set; }
        public ICollection<Followers> Followers { get; set; }
        public enum ProductType
        {
            Mobile = 1, web = 2, IoT = 3, Platform = 4
        }
    }
}