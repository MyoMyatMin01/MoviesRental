using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MoviesRental.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Job is required")]
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }
    }
}