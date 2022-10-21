using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers;

public class BooksController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}