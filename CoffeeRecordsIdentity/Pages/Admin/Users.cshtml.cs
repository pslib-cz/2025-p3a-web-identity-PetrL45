using CoffeeRecordsIdentity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoffeeRecordsIdentity.Pages.Admin
{
    [Authorize(Roles = "admin")]
    public class UsersModel : PageModel
    {
        public List<ApplicationUser> users;
        public void OnGet()
        {
            users = new List<ApplicationUser>();
        }
    }
}
