using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AboutMe.Models;
using AboutMe.Service;

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
    public IActionResult Contact(ContactModel question)
    {
        string userName = question.Name;
        string userEmail = question.Email;
        string userMsg = question.Message;

        EmailSender.SendMail(userEmail, userName, userMsg);
       
        return View("Contact");
    }




    public IActionResult Privacy() { return View(); }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

