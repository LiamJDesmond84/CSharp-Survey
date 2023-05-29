using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CSharp_Survey.Models;

namespace CSharp_Survey.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpPost("survey")]
    public IActionResult Submission(Survey yourSurvey)
    {
        return View(yourSurvey);
    }
}
