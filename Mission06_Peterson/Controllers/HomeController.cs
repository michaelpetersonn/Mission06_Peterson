using Microsoft.AspNetCore.Mvc;
using Mission06_Peterson.Models;

namespace Mission06_Peterson.Controllers;

public class HomeController : Controller
{
    private readonly MovieCollectionContext _context;

    public HomeController(MovieCollectionContext context)
    {
        _context = context;
    }

    // Home page
    public IActionResult Index()
    {
        return View();
    }

    // Get to Know Joel page
    public IActionResult GetToKnowJoel()
    {
        return View();
    }

    // Display AddMovie form
    [HttpGet]
    public IActionResult AddMovie()
    {
        return View();
    }
    // This is to show our confirmation and send it with our post method
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult AddMovie(Movie movie)
    {
        if (ModelState.IsValid)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return RedirectToAction("Confirmation");
        }
        return View(movie);
    }
    public IActionResult Confirmation()
    {
        return View();
    }
}