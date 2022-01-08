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
    public class IndexModel : PageModel
    {
        private readonly HOGYE_DENIS.Data.HOGYE_DENISContext _context;

        public IndexModel(HOGYE_DENIS.Data.HOGYE_DENISContext context)
        {
            _context = context;
        }

        public IList<Phone> Phone { get;set; }

        public async Task OnGetAsync()
        {
            Phone = await _context.Phone.ToListAsync();
        }
    }
}
