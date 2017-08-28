using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Web.Models
{
    public interface IRepository
    {
        List<Employee> GetAll();
    }
}
