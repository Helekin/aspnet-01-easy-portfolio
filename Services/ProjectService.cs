using aspnet_01_easy_portfolio.Models;

namespace aspnet_01_easy_portfolio.Services
{
    public class ProjectService:IProjectService
    {
        public List<ProjectViewModel> GetProjects()
        {
            return new List<ProjectViewModel>(){
        new() {
            Title="Amazon",
            Description="E-Commerce",
            Link="https://www.amazon.com/",
            ImageUrl="/img/amazon.PNG"
        },
        new() {
            Title="New York Times",
            Description="Blog",
            Link="https://www.nytimes.com/",
            ImageUrl="/img/nyt.PNG"
        },
        new() {
            Title="Reddit",
            Description="Social App",
            Link="https://www.reddit.com/",
            ImageUrl="/img/reddit.PNG"
        },
        new() {
            Title="Steam",
            Description="Games",
            Link="https://store.steampowered.com/",
            ImageUrl="/img/steam.PNG"
        }
        };
        }
    }
}