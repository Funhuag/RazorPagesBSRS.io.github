using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBSRS.Pages.Patients
{
    public class LoginModel : PageModel
    {
        public string UserName = "";
        public string Password = "";

        [HttpPost]
        public IActionResult OnPost()
        {
            UserName = Request.Form["UserName"];
            Password = Request.Form["Password"];

            if (!String.IsNullOrWhiteSpace(UserName) || !String.IsNullOrWhiteSpace(Password))
            {
                if (UserName != "123" || Password != "456")
                {
                    Response.Redirect("./Error");
                }
                else
                {
                    Response.Redirect("./Index");
                }
            }
            return Page();
        }
    }
}
