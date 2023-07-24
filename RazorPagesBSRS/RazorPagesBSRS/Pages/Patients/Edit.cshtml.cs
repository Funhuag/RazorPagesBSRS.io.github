using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesBSRS.Data;
using RazorPagesBSRS.Model;

namespace RazorPagesBSRS.Pages.Patients
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesBSRS.Data.RazorPagesBSRSContext _context;

        public EditModel(RazorPagesBSRS.Data.RazorPagesBSRSContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BSRS BSRS { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.BSRS == null)
            {
                return NotFound();
            }

            var bsrs =  await _context.BSRS.FirstOrDefaultAsync(m => m.ID == id);
            if (bsrs == null)
            {
                return NotFound();
            }
            BSRS = bsrs;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //因時間在修改過後會跑不出來(create用的是datetime.now)故暫時棄坑
            _context.Attach(BSRS).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BSRSExists(BSRS.ID))
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

        private bool BSRSExists(int id)
        {
          return (_context.BSRS?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
