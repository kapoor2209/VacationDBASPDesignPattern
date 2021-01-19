using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VacationDBASPDesignPattern.Data;
using VacationDBASPDesignPattern.Models;

namespace VacationDBASPDesignPattern.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly VacationDBASPDesignPattern.Data.VacationDBASPDesignPatternContext _context;

        public DetailsModel(VacationDBASPDesignPattern.Data.VacationDBASPDesignPatternContext context)
        {
            _context = context;
        }

        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employee.FirstOrDefaultAsync(m => m.EmpId == id);

            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
