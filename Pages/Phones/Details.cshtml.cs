using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HOGYE_DENIS.Data;
using HOGYE_DENIS.Models;

namespace HOGYE_DENIS.Pages.Phones
{
    public class DetailsModel : PageModel
    {
        private readonly HOGYE_DENIS.Data.HOGYE_DENISContext _context;

        public DetailsModel(HOGYE_DENIS.Data.HOGYE_DENISContext context)
        {
            _context = context;
        }

        public Phone Phone { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Phone = await _context.Phone.FirstOrDefaultAsync(m => m.ID == id);

            if (Phone == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
