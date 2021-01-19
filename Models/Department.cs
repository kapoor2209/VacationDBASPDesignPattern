using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacationDBASPDesignPattern.Models
{
    public class Department
    {
        [Key] // data annotation key to set unique id
        public int DeptId { get; set; } // department id
        public string DeptName { get; set; } // department name

        public List<Employee> Employees { get; set; } // references employee
        public Department() // ctor
        {
            Employees = new List<Employee>(); // init object
        }
    }
}
