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
        

        // GET: CourseScores
        public async Task<IActionResult> Index()
        {
            return View(Admin.GetAllScores());

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
                    if (Admin.GetCourseScoreByScoreId(courseScore.Id) == null)
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
            return View(courseScore);
        }


       
    }
}
