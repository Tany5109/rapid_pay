using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication6.Pages
{
    public class transactionModel : PageModel
    {
        public bool hasData = false;
        public string upiid = "";
        public string amount = "";
        public string note = "";

        public void OnGet()
        {
        }

        public void OnPost()
        {
            hasData = true;
            upiid = Request.Form["UPI ID"];
            amount = Request.Form["Amount"];
            note = Request.Form["Note"];

        }
    }
}
