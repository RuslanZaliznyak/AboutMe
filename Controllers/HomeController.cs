using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AboutMe.Models;

namespace AboutMe.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index() { return View(); }

    public IActionResult AboutMe() { return View(); }

    public IActionResult Portfolio() { return View(); }

    public IActionResult Resume() { return View(); }

    [HttpGet]
    public IActionResult Contact() {
        return View();
    }

    [HttpPost]
    public IActionResult Contact(ContactModel contactModel)
    {
        if (ModelState.IsValid) { string valid = "valid"; }
        else { string invalid = "invalid"; }

        return View("Contact");
    }




    public IActionResult Privacy() { return View(); }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

