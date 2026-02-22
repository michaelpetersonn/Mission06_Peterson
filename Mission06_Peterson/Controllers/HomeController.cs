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
    
}