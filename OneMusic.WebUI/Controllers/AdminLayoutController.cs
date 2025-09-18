using Microsoft.AspNetCore.Mvc;

namespace OneMusic.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index() // Action method to render the admin layout view 
        {
            return View(); // Returns the default view for the admin layout
        }
    }
}
