﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EstudoMVC.Models;

namespace EstudoMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(string id, string categoria)
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Privacys()
    {
        return View("Privacy"); //especificando a view
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
