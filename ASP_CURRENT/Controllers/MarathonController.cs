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
            var allQuestions = questionStorage.GetAllQuestions();
            int countOfQuestions = allQuestions.Count;
            if (question == null)
            {
                return NotFound();
            }

            // додумать логику прохождения последнего вопроса 
            // и придумать обработку последнего вопроса (чтобы после ответа на последний вопрос появлялась кнопка какая-нибудь)
            if (question.Id != countOfQuestions)
            {
                ViewBag.CountOfQuestions = countOfQuestions;
                return View(question);
            }
            else
            {
                return RedirectToAction("EndMarathon");
            }
            //return View(question);

        }

        [HttpPost]
        public IActionResult Answer(int id, int selectedAnswerIndex)
        {
            var question = questionStorage.GetQuestion(id);
            if (question == null)
            {
                return NotFound();
            }

            if (id == questionStorage.GetAllQuestions().Count - 1)
            {
                /*ViewBag.Question
                ViewBag.Explanation*/
                bool isCorrectSecond = question.CorrectAnswerIndex == selectedAnswerIndex;
                ViewBag.IsCorrectSecond = isCorrectSecond;


                return View("EndMarathon", question);
            }

            bool isCorrect = question.CorrectAnswerIndex == selectedAnswerIndex;
            ViewBag.IsCorrect = isCorrect;
            ViewBag.Explanation = question.Explanation;
            return View("Result", question);
        }

        public IActionResult Explanation(int id)
        {
            var question = questionStorage.GetQuestion(id);
            ViewBag.Explanation = question.Explanation;
            return View("Explanation", question);
        }

        public IActionResult EndMarathon()
        {
            return View();
        }
    }
}
