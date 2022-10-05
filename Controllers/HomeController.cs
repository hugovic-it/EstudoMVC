using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EstudoMVC.Models;

namespace EstudoMVC.Controllers;

[Route("")]
[Route("gestao-clientes")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [Route("pagina-inicial")]
    public IActionResult Index(string id, string categoria)
    {
        return View();
    }

    [Route("privacidade")]
    [Route("politica-de-privacidade")]
    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Privacys()
    {
        return View("Privacy"); //especificando a view
    }
    
    [Route("Error")]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
