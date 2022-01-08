using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HOGYE_DENIS.Data;
using HOGYE_DENIS.Models;

namespace HOGYE_DENIS.Pages.Phones
{
    public class CreateModel : PageModel
    {
        private readonly HOGYE_DENIS.Data.HOGYE_DENISContext _context;

        public CreateModel(HOGYE_DENIS.Data.HOGYE_DENISContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Phone Phone { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Phone.Add(Phone);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
