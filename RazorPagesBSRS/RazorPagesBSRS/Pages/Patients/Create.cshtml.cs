using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesBSRS.Data;
using RazorPagesBSRS.Model;
using System.Data.SqlClient;

namespace RazorPagesBSRS.Pages.Patients
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesBSRS.Data.RazorPagesBSRSContext _context;
        public CreateModel(RazorPagesBSRS.Data.RazorPagesBSRSContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BSRS BSRS { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD

        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.BSRS == null || BSRS == null)
            {
                return Page();
            }

            _context.BSRS.Add(BSRS);
            await _context.SaveChangesAsync();

            int len = _context.BSRS.Where(c => c.Professionalnum == BSRS.Professionalnum).OrderBy(c => c.ID).LastOrDefault().Professionalnum.Length;
            if(len < 7)
            {
                string pronum = _context.BSRS.Where(c => c.Professionalnum == BSRS.Professionalnum).OrderBy(c => c.ID).LastOrDefault().Professionalnum;
                string str = '0' + pronum;
                BSRS.Professionalnum = str;
                await _context.SaveChangesAsync();
            }
            
            int id = _context.BSRS.Where(c => c.PatientID == BSRS.PatientID).OrderBy(c => c.ID).LastOrDefault().ID;

            return RedirectToPage("./Details", new { id = id });
        }
    }
}
