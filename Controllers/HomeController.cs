using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aspneto.Models;

namespace aspneto.Controllers;

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

    public IActionResult Contact()
    {
        return View();
    }

    public ActionResult Usuario()
    {
        var usuario = new Usuario();

        return View(usuario);
    }

    [HttpPost]
    public ActionResult Usuario(Usuario usuario)
    {
        if (ModelState.IsValid)
            return View("Resultado", usuario);

        return View(usuario);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
