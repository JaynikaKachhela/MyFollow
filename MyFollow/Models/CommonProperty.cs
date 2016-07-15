﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyFollow.Models
{
    public class CommonProperty
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public string CreatedDate { get; set; }
        [DataType(DataType.Date)]
        public string LastModifiedDate { get; set; }
    }
}