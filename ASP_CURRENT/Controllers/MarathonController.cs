using ASP_CURRENT.Models;
using ASP_TrafficRules.Db;
using ASP_TrafficRules.Db.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ASP_CURRENT.Controllers
{
    public class MarathonController : Controller
    {
		private readonly DataBaseContext databaseContext;
		//private readonly IQuestionStorage questionStorage;

        public MarathonController(/*IQuestionStorage questionStorage, */DataBaseContext databaseContext)
        {
            //this.questionStorage = questionStorage;
			this.databaseContext = databaseContext;
		}

        public IActionResult Index()
        {
            var questions = databaseContext.Questions.ToList();
            var options = databaseContext.QuestionOptions.ToList();

            List<QuestionViewModel> questionsViewModel = new List<QuestionViewModel>();
            foreach (var question in questions)
            {
                question.QuestionOptions = options.Where(x => x.QuestionId == question.Id).ToList();

                var questionViewModel = new QuestionViewModel()
                {
                    Id = question.Id,
                    Text = question.Text,
                    QuestionOptions = question.QuestionOptions.Select(option => new QuestionOptionsViewModel(option.Id, option.Text, option.QuestionId)
                    {
                        Question = option.Question
                    }).ToList(),
                    CorrectAnswerIndex = question.CorrectAnswerIndex,
                    Explanation = question.Explanation
                };

                questionsViewModel.Add(questionViewModel);
            }

            return View(questionsViewModel);

            //var questions = questionStorage.GetAllQuestions();
            /*return View(questions);*/
            
        }
        
        public IActionResult Question(Guid id)
        {
            var question = databaseContext.Questions.FirstOrDefault(question => question.Id == id);
			//var question = questionStorage.GetQuestion(id);

			var allQuestions = databaseContext.Questions.ToList();
			//var allQuestions = questionStorage.GetAllQuestions();

            int countOfQuestions = allQuestions.Count;
            if (question == null)
            {
                return NotFound();
            }

            question.QuestionOptions = databaseContext.QuestionOptions.Where(x => x.QuestionId == id).ToList();

            var questionViewModel = new QuestionViewModel()
            {
                Id = question.Id,
                Text = question.Text,
                QuestionOptions = question.QuestionOptions.Select(option => new QuestionOptionsViewModel(option.Id, option.Text, option.QuestionId)
                {
                    Question = option.Question
                }).ToList(),
                CorrectAnswerIndex = question.CorrectAnswerIndex,
                Explanation = question.Explanation
            };


            if (allQuestions.IndexOf(question) != countOfQuestions)
            {
                ViewBag.CountOfQuestions = countOfQuestions;
                return View(questionViewModel);
            }
            else
            {
                return RedirectToAction("EndMarathon");
            }
            //return View(question);

        }

        [HttpPost]
        public IActionResult Answer(Guid id, int selectedAnswerIndex)
        {
			var allQuestions = databaseContext.Questions.ToList();
            var countOfQuestions = allQuestions.Count;

			var question = databaseContext.Questions.FirstOrDefault(question => question.Id == id);
            //var question = questionStorage.GetQuestion(id);

            //var questionOptions = databaseContext.QuestionOptions.Where(x => x.QuestionId == id).ToList();
            question.QuestionOptions = databaseContext.QuestionOptions.Where(x => x.QuestionId == id).ToList();

            var questionViewModel = new QuestionViewModel()
            {
                Id = question.Id,
                Text = question.Text,
                QuestionOptions = question.QuestionOptions.Select(option => new QuestionOptionsViewModel(option.Id, option.Text, option.QuestionId)
                {
                    Question = option.Question
                }).ToList(),
                CorrectAnswerIndex = question.CorrectAnswerIndex,
                Explanation = question.Explanation
            };


            if (question == null)
            {
                return NotFound();
            }

            
            if (id == allQuestions[countOfQuestions - 1].Id)
				{
                /*ViewBag.Question
                ViewBag.Explanation*/
                bool isCorrectSecond = question.CorrectAnswerIndex == selectedAnswerIndex;
                ViewBag.IsCorrectSecond = isCorrectSecond;


                return View("EndMarathon", questionViewModel);
            }

            

            bool isCorrect = question.CorrectAnswerIndex == selectedAnswerIndex;
            ViewBag.IsCorrect = isCorrect;
            ViewBag.Explanation = question.Explanation;
            ViewBag.Question = question;
            ViewBag.AllQuestions = allQuestions;
            return View("Result", questionViewModel);
        }

        public IActionResult Explanation(Guid id)
        {
            //var question = questionStorage.GetQuestion(id);
            var question = databaseContext.Questions.FirstOrDefault(question => question.Id == id);

            question.QuestionOptions = databaseContext.QuestionOptions.Where(x => x.QuestionId == id).ToList();

            var questionViewModel = new QuestionViewModel()
            {
                Id = question.Id,
                Text = question.Text,
                QuestionOptions = question.QuestionOptions.Select(option => new QuestionOptionsViewModel(option.Id, option.Text, option.QuestionId)
                {
                    Question = option.Question
                }).ToList(),
                CorrectAnswerIndex = question.CorrectAnswerIndex,
                Explanation = question.Explanation
            };
            ViewBag.Explanation = questionViewModel.Explanation;

            // создает новую коллекцию, где каждый элемент - это значение свойства Text из каждого объекта QuestionOptionsМетод ToList преобразует результат работы Select (который является IEnumerable<string>) в List<string>.

            return View("Explanation", questionViewModel);
        }

        public IActionResult EndMarathon()
        {
            return View();
        }
    }
}
