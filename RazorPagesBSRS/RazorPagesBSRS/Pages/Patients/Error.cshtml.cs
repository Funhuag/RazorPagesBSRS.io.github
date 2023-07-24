using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBSRS.Pages.Patients
{
    public class ErrorModel : PageModel
    {
        public ActionResult Error()
        {
            return Page();
        }

        public void OnGet()
        {
        }
    }
}
