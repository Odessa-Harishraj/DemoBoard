using Microsoft.AspNetCore.Mvc;
using JiraClone.Data;

namespace JiraClone.Controllers
{
    public class StatusController : Controller
    {
        private readonly AppDbContext _db;

        public StatusController(AppDbContext db)
        {
            _db = db;
        }

        // GET: Status
        public IActionResult Index()
        {
            var statuses = _db.StatusConfigs.ToList();
            return View(statuses);
        }

        // GET: Status/Create
        public IActionResult Create()
        {
            return View(new StatusConfig());
        }

        // POST: Status/Create
        [HttpPost]
        public IActionResult Create(StatusConfig status)
        {
            if (!ModelState.IsValid)
                return View(status);

            _db.StatusConfigs.Add(status);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: Status/Edit/5
        public IActionResult Edit(int id)
        {
            var status = _db.StatusConfigs.Find(id);
            if (status == null) return NotFound();

            return View(status);
        }

        // POST: Status/Edit
        [HttpPost]
        public IActionResult Edit(StatusConfig status)
        {
            if (!ModelState.IsValid)
                return View(status);

            _db.StatusConfigs.Update(status);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: Status/Delete/5
        public IActionResult Delete(int id)
        {
            var status = _db.StatusConfigs.Find(id);
            if (status == null) return NotFound();

            return View(status);
        }

        // POST: Status/Delete
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var status = _db.StatusConfigs.Find(id);
            if (status != null)
            {
                _db.StatusConfigs.Remove(status);
                _db.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
