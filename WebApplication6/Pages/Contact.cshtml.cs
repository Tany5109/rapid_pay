using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication6.Pages
{
    public class ContactModel : PageModel
    {
        public bool hasData = false;
        public string firstname = "";
        public string lastname ="";
        public string message = "";

        public void OnGet()
        {
        }

        public void OnPost()
        {
            hasData= true;
            firstname = Request.Form["UPI ID"];
            lastname = Request.Form["Amount"];
            message = Request.Form["Add a note"];
        }
    }
}
