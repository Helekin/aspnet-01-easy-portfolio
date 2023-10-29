using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aspnet_01_easy_portfolio.Models;

namespace aspnet_01_easy_portfolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var projects = GetProjects().Take(3).ToList();

        var home = new HomeViewModel() { Projects = projects };

        return View(home);
    }

    private List<ProjectViewModel> GetProjects()
    {
        return new List<ProjectViewModel>(){
        new ProjectViewModel{
            Title="Amazon",
            Description="E-Commerce",
            Link="https://www.amazon.com/",
            ImageUrl="/img/amazon.PNG"
        },
        new ProjectViewModel{
            Title="New York Times",
            Description="Blog",
            Link="https://www.nytimes.com/",
            ImageUrl="/img/nyt.PNG"
        },
        new ProjectViewModel{
            Title="Reddit",
            Description="Social App",
            Link="https://www.reddit.com/",
            ImageUrl="/img/reddit.PNG"
        },
        new ProjectViewModel{
            Title="Steam",
            Description="Games",
            Link="https://store.steampowered.com/",
            ImageUrl="/img/steam.PNG"
        }
        };
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
