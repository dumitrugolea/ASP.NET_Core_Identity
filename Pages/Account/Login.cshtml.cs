using System.ComponentModel.DataAnnotations;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_IdentityServer4.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credential Credential { get; set; }
        public void OnGet()
        {
        }
    }

    public class Credential
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
