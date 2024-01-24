using _1.Models;
using Core.Flash;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _1.Pages
{
    public class SignModel : PageModel
    {
        private readonly CakesContext _db;
        private readonly ILogger<CakesContext> _logger;
        private readonly IFlasher _f;
        public SignModel(CakesContext db, ILogger<CakesContext> logger, IFlasher f)
        {
            _db = db;
           _logger = logger;
            _f = f;

        }
        [HttpPost]
        public IActionResult OnPost(User user)
        {
            try
            {
                _db.Users.Add(user);
                _db.SaveChanges();
                return RedirectToPage("./Index");
            }
            catch (Exception ex)
            {
                return RedirectToPage("./Sign");
            }
        }

        public void OnGet()
        {
        }
        /*public IActionResult OnPost(User user)
        {
            try
            {
                _db.User.Add(user);
                _db.SaveChanges();
                _logger.LogInformation($"ѕользователь {user.Name} успешно зарегестрирован");
                _f.Flash(Types.Success, $"ѕользователь  {user.Name} зарегистрирован!", dismissable: true);

                return RedirectToPage("Index");
            }

            catch (Exception ex)
            {
                _logger.LogError($"{ex.Message}");
            }
            return Page();
        }*/

    }
}
