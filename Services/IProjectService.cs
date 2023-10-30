using aspnet_01_easy_portfolio.Models;

namespace aspnet_01_easy_portfolio.Services
{
    public interface IProjectService
    {
        List<ProjectViewModel> GetProjects();
    }
}