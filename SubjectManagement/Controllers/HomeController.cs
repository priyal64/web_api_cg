using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SubManagement.Data;
using SubManagement.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SubManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewBag.SavedSubjects = await _context.Subjects
                .Include(s => s.Topics)
                    .ThenInclude(t => t.Subtopics)
                .ToListAsync();

            var model = new List<Subject>
            {
                new Subject
                {
                    SubjectName = "",
                    Topics = new List<Topic>
                    {
                        new Topic
                        {
                            TopicName = "",
                            Subtopics = new List<SubTopic>
                            {
                                new SubTopic { SubtopicName = "" }
                            }
                        }
                    }
                }
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(List<Subject> subjects)
        {
            if (subjects == null || !subjects.Any())
            {
                ModelState.AddModelError("", "No subjects submitted.");
                return View(subjects);
            }

            foreach (var subject in subjects)
            {
                foreach (var topic in subject.Topics)
                {
                    topic.Subject = subject;
                    foreach (var sub in topic.Subtopics)
                    {
                        sub.Topic = topic;
                    }
                }
                _context.Subjects.Add(subject);
            }

            await _context.SaveChangesAsync();
            TempData["Success"] = "Data saved successfully!";
            return RedirectToAction("Index");
        }

        public IActionResult Privacy() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}