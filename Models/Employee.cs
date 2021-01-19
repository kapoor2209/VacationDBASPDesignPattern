using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VacationDBASPDesignPattern.Models
{
    public class Employee
    {
        [Key]// data annotation to set unique id
        public int EmpId { get; set; } // employee id
        public string FirstName { get; set; } // first name
        public string LastName { get; set; } // last name
        public DateTime StartingDate { get; set; } // employee joining date
        [DataType(DataType.EmailAddress)] 
        public string Email { get; set; } // employee email address
        [ForeignKey("Department")]
        public int DeptID { get; set; } // Foreign key to deparmtnet entity
        public Department Departments { get; set; } //ref

        public List<RequestDate> RequestDates { get; set; } // ref to Request dates
        public List<DaysTaken> DaysTakens { get; set; } // ref to DaysTaken
        public Employee() // ctor
        {
            // initializing objects
            RequestDates = new List<RequestDate>();
            DaysTakens = new List<DaysTaken>();
        }

    }
}
