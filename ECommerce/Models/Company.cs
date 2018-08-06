using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Company
    {

       
            [Key]
            public int CompanyId { get; set; }

            [Required(ErrorMessage = "The field {0} is required")]
            [MaxLength(50, ErrorMessage = "The filed {0} must be maximun {1} characters length")]
            [Display(Name = "Company")]
            [Index("Company_Name_Index", IsUnique = true)] //No hayan dos compañias con el mismo nombre
            public string Name { get; set; }

            [Required(ErrorMessage = "The field {0} is required")]
            [MaxLength(20, ErrorMessage = "The filed {0} must be maximun {1} characters length")]
            [DataType(DataType.PhoneNumber)]
            public string Phone { get; set; }

            [Required(ErrorMessage = "The field {0} is required")]
            [MaxLength(100, ErrorMessage = "The filed {0} must be maximun {1} characters length")]
            public string Address { get; set; }

       
            [DataType(DataType.ImageUrl)]
            public string Logo { get; set; }

            [Required(ErrorMessage = "The field {0} is required")]
            [Range(1, double.MaxValue, ErrorMessage = "You must select a {0}")] //Validador para seleccionar en el Dropdownlist
            public int DepartmentId { get; set; }


            [Required(ErrorMessage = "The field {0} is required")]
            [Range(1, double.MaxValue, ErrorMessage = "You must select a {0}")] //Validador para seleccionar en el Dropdownlist
            public int CityId { get; set; }


            public virtual Department Department { get; set; }
            public virtual City City { get; set; }

    }
}