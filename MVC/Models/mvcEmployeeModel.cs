using MVC.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class mvcEmployeeModel
    {
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        [Display(Name = "Name", ResourceType = typeof(Language))]
        public string Name { get; set; }

        [Display(Name = "Position", ResourceType = typeof(Language))]
        public string Position { get; set; }
        [Display(Name = "Age", ResourceType = typeof(Language))]
        public Nullable<int> Age { get; set; }
        [Display(Name = "Salary", ResourceType = typeof(Language))]
        public Nullable<int> Salary { get; set; }
    }
}