using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Northwest_Solution.Models
{
    public class Employee
    {
        [Required]
        public int EmployeeID { get; set; }
        [DisplayName("Position")]
        public string Title { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}