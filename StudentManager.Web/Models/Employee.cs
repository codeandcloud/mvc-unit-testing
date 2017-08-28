using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManager.Web.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Age { get; set; }
    }
}