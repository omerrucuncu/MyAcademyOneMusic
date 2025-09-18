using Microsoft.AspNetCore.Mvc;
using OneMusic.BusinessLayer.Abstract;

namespace OneMusic.WebUI.Controllers
{
    public class AdminAboutController : Controller
    {
        private readonly IAboutService _aboutService; // Service for about-related operations 

        public AdminAboutController(IAboutService aboutService) // Constructor with dependency injection for the about service
        {
            _aboutService = aboutService; // Initialize the about service field 
        }

        public IActionResult Index()
        {
            var abouts = _aboutService.TGetAll(); // Retrieve all about entries using the service
            return View(abouts); // Pass the retrieved entries to the view for display
        }
    }
}
