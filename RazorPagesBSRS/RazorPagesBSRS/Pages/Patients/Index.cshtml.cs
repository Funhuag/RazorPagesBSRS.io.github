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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesBSRS.Data.RazorPagesBSRSContext _context;
        public IndexModel(RazorPagesBSRS.Data.RazorPagesBSRSContext context)
        {
            _context = context;
        }

        public IList<BSRS> BSRS { get;set; } = default!;

        public async Task OnGetAsync(string sortOrder)
        {
            if (_context.BSRS != null)
            {
                BSRS = await _context.BSRS.ToListAsync();
            }
        }
    }
}
