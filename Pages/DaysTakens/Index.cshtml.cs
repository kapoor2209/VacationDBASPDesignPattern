using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VacationDBASPDesignPattern.Data;
using VacationDBASPDesignPattern.Models;

namespace VacationDBASPDesignPattern.Pages.DaysTakens
{
    public class IndexModel : PageModel
    {
        private readonly VacationDBASPDesignPattern.Data.VacationDBASPDesignPatternContext _context;

        public IndexModel(VacationDBASPDesignPattern.Data.VacationDBASPDesignPatternContext context)
        {
            _context = context;
        }

        public IList<DaysTaken> DaysTaken { get;set; }

        public async Task OnGetAsync()
        {
            DaysTaken = await _context.DaysTaken.ToListAsync();
        }
    }
}
