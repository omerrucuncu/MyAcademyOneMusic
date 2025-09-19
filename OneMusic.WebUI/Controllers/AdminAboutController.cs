using Microsoft.AspNetCore.Mvc;
using OneMusic.BusinessLayer.Abstract;
using OneMusic.EntityLayer.Entities;

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

        public IActionResult DeleteAbout(int id)
        {
            _aboutService.TDelete(id); // Delete the about entry with the specified ID using the service
            return RedirectToAction("Index"); // Redirect to the Index action to refresh the list of about entries
        }

        [HttpGet]
        public IActionResult CreateAbout() // Render the form for creating a new about entry 
        {
            return View(); // Render the view for creating a new about entry
        }

        [HttpPost]
        public IActionResult CreateAbout(About about)  // Handle the form submission for creating a new about entry 
        {
            if (ModelState.IsValid) // Check if the model state is valid
            {
                _aboutService.TInsert(about); // Insert the new about entry using the service
                return RedirectToAction("Index", "AdminAbout"); // Redirect to the Index action to show the updated list
            }
            return View(about); // If the model state is invalid, return to the view with the current about data
        }


        [HttpGet]
        public IActionResult UpdateAbout(int id) // Render the form for editing an existing about entry
        {
            var about = _aboutService.TGetById(id); // Retrieve the about entry with the specified ID using the service
            if (about == null) // If the about entry does not exist
            {
                return NotFound(); // Return a 404 Not Found response
            }
            return View(about); // Pass the retrieved about entry to the view for editing
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about) // Handle the form submission for updating an existing about entry 
        {
            if (ModelState.IsValid) // Check if the model state is valid
            {
                _aboutService.TUpdate(about); // Update the about entry using the service
                return RedirectToAction("Index", "AdminAbout"); // Redirect to the Index action to show the updated list
            }
            return View(about); // If the model state is invalid, return to the view with the current about data
        }
    }
}
