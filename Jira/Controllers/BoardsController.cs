using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JiraClone.Data;

namespace JiraClone.Controllers
{
    public class BoardsController : Controller
    {
        private readonly AppDbContext _db;

        public BoardsController(AppDbContext db)
        {
            _db = db;
        }

        // GET: Boards
        public IActionResult Index()
        {
            var boards = _db.Boards.Include(b => b.Project).ToList();
            return View(boards); // ✅ Pass List<Board>
        }

        public IActionResult Create()
        {
            ViewBag.Projects = _db.Projects.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Board board)
        {
            _db.Boards.Add(board);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
