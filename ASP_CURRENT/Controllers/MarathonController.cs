using Microsoft.AspNetCore.Mvc;

namespace ASP_CURRENT.Controllers
{
    public class MarathonController : Controller
    {
        private readonly IQuestionStorage questionStorage;

        public MarathonController(IQuestionStorage questionStorage)
        {
            this.questionStorage = questionStorage;
        }

        public IActionResult Index()
        {
            var questions = questionStorage.GetAllQuestions();
            return View(questions);
            /*return View();*/
        }
        
        public IActionResult Question(int id)
        {
            var question = questionStorage.GetQuestion(id);
            if (question == null)
            {
                return NotFound();
            }
            return View(question);
        }

        [HttpPost]
        public IActionResult Answer(int id, int selectedAnswerIndex)
        {
            var question = questionStorage.GetQuestion(id);
            if (question == null)
            {
                return NotFound();
            }

            bool isCorrect = question.CorrectAnswerIndex == selectedAnswerIndex;
            ViewBag.IsCorrect = isCorrect;
            ViewBag.Explanation = question.Explanation;
            return View("Result", question);
        }
    }
}
