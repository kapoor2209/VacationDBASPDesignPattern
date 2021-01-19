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
    public class IndexModel : PageModel
    {
        private readonly VacationDBASPDesignPattern.Data.VacationDBASPDesignPatternContext _context;

        public IndexModel(VacationDBASPDesignPattern.Data.VacationDBASPDesignPatternContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee.ToListAsync();
        }
    }
}
