using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesBSRS.Data;
using RazorPagesBSRS.Model;

namespace RazorPagesBSRS.Pages.Patients
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesBSRS.Data.RazorPagesBSRSContext _context;

        public DetailsModel(RazorPagesBSRS.Data.RazorPagesBSRSContext context)
        {
            _context = context;
        }

      public BSRS BSRS { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.BSRS == null)
            {
                return NotFound();
            }

            var bsrs = await _context.BSRS.FirstOrDefaultAsync(m => m.ID == id);
            if (bsrs == null)
            {
                return NotFound();
            }
            else 
            {
                BSRS = bsrs;
            }
            return Page();
        }
    }
}
