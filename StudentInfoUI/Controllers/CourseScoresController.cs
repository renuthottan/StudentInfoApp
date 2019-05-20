using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentInfoApp;

namespace StudentInfoUI.Controllers
{
    [Authorize]

    public class CourseScoresController : Controller
    {
        private readonly AdminContext _context;

        public CourseScoresController(AdminContext context)
        {
            _context = context;
        }

        // GET: CourseScores
        public async Task<IActionResult> Index()
        {
            return View(Admin.GetScoresForStudent(1));

        }

        // GET: CourseScores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseScore = Admin.GetCourseScoreByScoreId(id.Value);

            if (courseScore == null)
            {
                return NotFound();
            }

            return View(courseScore);
        }

        // GET: CourseScores/Create
        public IActionResult Create()
        {
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Address");
            return View();
        }

        // POST: CourseScores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentId,CourseId,Score")] CourseScore courseScore)
        {
            if (ModelState.IsValid)
            {
                Admin.AddStudentScore(courseScore.StudentId, courseScore.CourseId, courseScore.Score );

                return RedirectToAction(nameof(Index));
            }
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Address", courseScore.StudentId);
            return View(courseScore);
        }

        // GET: CourseScores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseScore = Admin.GetCourseScoreByScoreId(id.Value);
            if (courseScore == null)
            {
                return NotFound();
            }
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Address", courseScore.StudentId);
            return View(courseScore);
        }

        // POST: CourseScores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StudentId,CourseId,Score")] CourseScore courseScore)
        {
            if (id != courseScore.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Admin.UpdateCourseScore(courseScore);

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseScoreExists(courseScore.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Address", courseScore.StudentId);
            return View(courseScore);
        }

        // GET: CourseScores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseScore = await _context.CourseScores
                .Include(c => c.Student)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courseScore == null)
            {
                return NotFound();
            }

            return View(courseScore);
        }

        // POST: CourseScores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseScore = await _context.CourseScores.FindAsync(id);
            _context.CourseScores.Remove(courseScore);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseScoreExists(int id)
        {
            return _context.CourseScores.Any(e => e.Id == id);
        }
    }
}
