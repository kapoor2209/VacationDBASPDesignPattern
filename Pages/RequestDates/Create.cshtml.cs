using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VacationDBASPDesignPattern.Data;
using VacationDBASPDesignPattern.Models;

namespace VacationDBASPDesignPattern.Pages.RequestDates
{
    public class CreateModel : PageModel
    {
        private readonly VacationDBASPDesignPattern.Data.VacationDBASPDesignPatternContext _context;

        public CreateModel(VacationDBASPDesignPattern.Data.VacationDBASPDesignPatternContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public RequestDate RequestDate { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.RequestDate.Add(RequestDate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
