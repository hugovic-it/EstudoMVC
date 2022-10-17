using Microsoft.AspNetCore.Mvc;

namespace EstudoMVC.Controllers
{
    public class FilmesController : Controller
    {
        [HttpGet]
        public IActionResult Adicionar(){
            return View();
        }        
    }
}