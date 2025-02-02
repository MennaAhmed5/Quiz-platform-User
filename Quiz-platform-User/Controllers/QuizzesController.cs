using Microsoft.AspNetCore.Mvc;
using Quiz_platform_User.BL.Managers.Quizzes;
using Quiz_platform_User.DAL.UnitOfWork;

namespace Quiz_platform_User.Controllers
{
    public class QuizzesController : Controller
    {
        private readonly IQuizManager _quizManager;
        public QuizzesController(IQuizManager quizManager)
        {
            _quizManager = quizManager;
       
        }
        [HttpGet]
        public IActionResult Index()
        {
            var quizzes = _quizManager.GetAll();
            return View(quizzes);
         
        }

        [HttpPost]
        public IActionResult Index(string name)
        {
            var quizzes = _quizManager.GetAll();
            if (!string.IsNullOrEmpty(name))
            {
                quizzes = quizzes.Where(q => q.Name.Contains(name));
            }

            return Json(quizzes.ToList());
        }


        [HttpGet]
        public IActionResult Details(int id)
        {           
            var quiz = _quizManager.GetDetailsById(id);         
            return View(quiz);
        }

        [HttpPost]
        public IActionResult Submit()
        {
   
            return RedirectToAction("Index");
        }

    }
}
