using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mission06_Peterson.Models;

namespace Mission06_Peterson.Controllers;

public class MovieController : Controller
{
    private readonly MovieCollectionContext _context;

    public MovieController(MovieCollectionContext context)
    {
        _context = context;
    }

  // Display all movies
    public IActionResult ShowMe()
    {
        var movies = _context.Movies
            .Include(m => m.Category)
            .ToList();

        return View(movies);
    }

    // Edit all movies GET
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var movie = _context.Movies.Find(id);

        if (movie == null)
        {
            return NotFound();
        }

        ViewBag.Categories = new SelectList(
            _context.Categories,
            "CategoryId",
            "CategoryName",
            movie.CategoryId
        );

        return View(movie);
    }

    [HttpPost]
    public IActionResult Edit(Movie movie)
    {
        if (ModelState.IsValid)
        {
            _context.Update(movie);
            _context.SaveChanges();
            return RedirectToAction("ShowMe");
        }

        //Show drop down for all the movies POST
        ViewBag.Categories = new SelectList(
            _context.Categories,
            "CategoryId",
            "CategoryName",
            movie.CategoryId
        );

        return View(movie);
    }

    // We delete all movies using our GET method
    [HttpGet]
    public IActionResult Delete(int id)
    {
        var movie = _context.Movies
            .Include(m => m.Category)
            .FirstOrDefault(m => m.MovieId == id);

        if (movie == null)
        {
            return NotFound();
        }

        return View(movie);
    }

    //Delete all movies using the POST method
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        var movie = _context.Movies.Find(id);

        if (movie != null)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }

        return RedirectToAction("ShowMe");
    }
}