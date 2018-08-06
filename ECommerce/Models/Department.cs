using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage ="The field {0} is required")]
        [MaxLength(50,ErrorMessage = "The filed {0} must be maximun {1} characters length")]
        [Display(Name="Department")]
        [Index("Department_Name_Index",IsUnique =true)] //No hayan dos departamentos con el mismo nombre
        public string Name { get; set; }

        public virtual ICollection<City>  Cities { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
    }
}