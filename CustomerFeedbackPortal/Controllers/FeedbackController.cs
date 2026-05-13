using Microsoft.AspNetCore.Mvc;
using CustomerFeedbackPortal.Models;

namespace CustomerFeedbackPortal.Controllers
{
    public class FeedbackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                return View("Submitted", feedback);
            }

            return View("Index", feedback);
        }
    }
}