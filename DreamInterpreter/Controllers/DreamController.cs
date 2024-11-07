using Microsoft.AspNetCore.Mvc;
using DreamInterpreter.Models; // Replace with the actual namespace

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View(new DreamModel());
    }

    [HttpPost]
    public IActionResult Index(DreamModel dream)
    {
        if (!string.IsNullOrEmpty(dream.Text))
        {
            // Perform some operation on dream.Text
            dream.Response = $"Processed text: {dream.Text.ToUpper()}"; // Example processing
        }

        return View(dream);
    }
}
