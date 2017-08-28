using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Web.Models
{
    public class WorkingEmployeeRepository : IRepository
    {
        public List<Employee> GetAll()
        {
            //call from database
            return new List<Employee>()
            {
                new Employee{
                    ID = 1,
                    FirstName = "Allan",
                    LastName = "Wilkins",
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 23
                },

                new Employee{
                    ID = 2,
                    FirstName = "Carson",
                    LastName = "Jenkins",
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 45
                },

                new Employee{
                    ID = 3,
                    FirstName = "Carson",
                    LastName = "Jake",
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 37
                },
                new Employee{
                    ID = 4,
                    FirstName = "Laura",
                    LastName = "Paul",
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 26
                }
            };
        }
    }
}
