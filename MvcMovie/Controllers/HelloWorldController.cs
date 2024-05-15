using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View(); //Calls the controller's View method.
                       //Uses a view template to generate an HTML response.
    }

    // 
    // GET: /HelloWorld/Welcome/ 
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
    //Uses HtmlEncoder.Default.Encode to protect the app from malicious input, such as through JavaScript.

    // Every public method in a controller is callable as an HTTP endpoint.In the sample above, both methods return a string.
}
