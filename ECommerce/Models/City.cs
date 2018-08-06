﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(50, ErrorMessage = "The filed {0} must be maximun {1} characters length")]
        [Display(Name="City")]
        public string Name { get; set; }


        [Required(ErrorMessage = "The field {0} is required")]
        [Range(1,double.MaxValue,ErrorMessage = "You must select a {0}")]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}