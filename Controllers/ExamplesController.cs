using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnet6_contenttype_ajax_examples.Models;

namespace dotnet6_contenttype_ajax_examples.Controllers;

public class ExamplesController : Controller
{
    public ExamplesController() { }

    public IActionResult FormEncoded()
    {
        return View();
    }

    public IActionResult JSONEncoded()
    {
        return View();
    }
}
