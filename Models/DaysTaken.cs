using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VacationDBASPDesignPattern.Models
{
    public class DaysTaken
    {
        [Key]
        public int DTId { get; set; } // id creation

        [ForeignKey("Employee")]
        public int EmpId { get; set; } // foreign key to employee
        public Employee Employees { get; set; }
        public string Type { get; set; } // type
        public string VacationType { get; set; } // vacation type
        public DateTime CDay { get; set; }

    }
}
