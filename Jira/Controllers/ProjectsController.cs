using Microsoft.AspNetCore.Mvc;
using JiraClone.Data;

namespace JiraClone.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly AppDbContext _db;

        public ProjectsController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Projects.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Project project)
        {
            Console.WriteLine($"Name: {project.Name}");
            Console.WriteLine($"Desc: {project.Description}");

            _db.Projects.Add(project);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


    }
}
