using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VacationDBASPDesignPattern.Data;
using VacationDBASPDesignPattern.Models;

namespace VacationDBASPDesignPattern.Pages.DaysTakens
{
    public class EditModel : PageModel
    {
        private readonly VacationDBASPDesignPattern.Data.VacationDBASPDesignPatternContext _context;

        public EditModel(VacationDBASPDesignPattern.Data.VacationDBASPDesignPatternContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(DaysTaken).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DaysTakenExists(DaysTaken.DTId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DaysTakenExists(int id)
        {
            return _context.DaysTaken.Any(e => e.DTId == id);
        }
    }
}
