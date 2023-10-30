using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aspnet_01_easy_portfolio.Models;
using aspnet_01_easy_portfolio.Services;

namespace aspnet_01_easy_portfolio.Controllers;

public class HomeController : Controller
{
    private readonly IProjectService _projectService;

    public HomeController(IProjectService projectService)
    {
        _projectService = projectService;
    }

    public IActionResult Index()
    {
        var projects = _projectService.GetProjects().Take(3).ToList();

        var home = new HomeViewModel() { Projects = projects };

        return View(home);
    }

    public IActionResult Projects()
    {
        var projects = _projectService.GetProjects();

        return View(projects);
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
