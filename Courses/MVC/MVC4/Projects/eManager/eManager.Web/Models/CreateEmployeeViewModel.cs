using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eManager.Web.Models
{
    public class CreateEmployeeViewModel
    {
        [HiddenInput(DisplayValue=false)]
        public virtual int id { get; set; }

        [Required]
        public virtual string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public virtual DateTime? HireDate { get; set; }

        public int DepartmentId { get; set; }
    }
}