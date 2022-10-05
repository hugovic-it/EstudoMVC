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
    [Route("")]
    [Route("pagina-inicial")]
    [Route("pagina-inicial/{id:int}/{categoria?}")]
    public IActionResult Index(int id, string categoria)
    {
        var filme = new Filme
        {
            Titulo = "oi",
            DataLancamento = DateTime.Now,
            Genero = null,
            Avaliacao = 10,
            Valor = 20000 
        };

       
        return RedirectToAction("Privacy",filme);
        return View();


    }

    [Route("privacidade")]
    [Route("politica-de-privacidade")]
    public IActionResult Privacy(Filme filme)
    {
        if (ModelState.IsValid){

        }

        foreach (var error in ModelState.Values.SelectMany( m => m.Errors))
        {
            System.Console.WriteLine(error.ErrorMessage);
        }
        //return Content("Qualquer coisa");
        return View();
    }

    [Route("Privacys")]
    public IActionResult Privacys()
    {
        var fileBytes = System.IO.File.ReadAllBytes(@"D:\arquivo.txt");
        var fileName = "ola.txt";
        return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        //return View("Privacy"); //especificando a view

        
    }
    
    [Route("Error")]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
