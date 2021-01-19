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
    public class DeleteModel : PageModel
    {
        private readonly VacationDBASPDesignPattern.Data.VacationDBASPDesignPatternContext _context;

        public DeleteModel(VacationDBASPDesignPattern.Data.VacationDBASPDesignPatternContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DaysTaken DaysTaken { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DaysTaken = await _context.DaysTaken.FirstOrDefaultAsync(m => m.DTId == id);

            if (DaysTaken == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DaysTaken = await _context.DaysTaken.FindAsync(id);

            if (DaysTaken != null)
            {
                _context.DaysTaken.Remove(DaysTaken);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
