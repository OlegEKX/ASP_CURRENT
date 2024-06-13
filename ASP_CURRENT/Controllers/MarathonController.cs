using ASP_CURRENT.Models;
using ASP_TrafficRules.Db;
using ASP_TrafficRules.Db.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;

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

            List<QuestionViewModel> questionsViewModel = new List<QuestionViewModel>();
            foreach (var item in questions)
            {
                var questionViewModel = new QuestionViewModel()
                {
                    Id = item.Id,
                    Text = item.Text,
                    Options = item.Options.Select(option => new QuestionOptionsViewModel
                    {
                        Id = option.Id,
                        Text = option.Text,
                        QuestionId = option.Id,
                        Question = option.Question
                    }).ToList(),
                    CorrectAnswerIndex = item.CorrectAnswerIndex,
                    Explanation = item.Explanation
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

            var questionViewModel = new QuestionViewModel()
            {
                Id = question.Id,
                Text = question.Text,
                Options = question.Options.Select(option => new QuestionOptionsViewModel
                {
                    Id = option.Id,
                    Text = option.Text,
                    QuestionId = option.Id,
                    Question = option.Question
                }).ToList(), // создает новую коллекцию, где каждый элемент - это значение свойства Text из каждого объекта QuestionOptionsМетод ToList преобразует результат работы Select (который является IEnumerable<string>) в List<string>.
                CorrectAnswerIndex = question.CorrectAnswerIndex,
                Explanation = question.Explanation
            };


            if (question.Id != allQuestions[countOfQuestions].Id)
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

            var questionViewModel = new QuestionViewModel()
            {
                Id = question.Id,
                Text = question.Text,
                Options = question.Options.Select(option => new QuestionOptionsViewModel
                {
                    Id = option.Id,
                    Text = option.Text,
                    QuestionId = option.Id,
                    Question = option.Question
                }).ToList(), // создает новую коллекцию, где каждый элемент - это значение свойства Text из каждого объекта QuestionOptionsМетод ToList преобразует результат работы Select (который является IEnumerable<string>) в List<string>.
                CorrectAnswerIndex = question.CorrectAnswerIndex,
                Explanation = question.Explanation
            };


            if (question == null)
            {
                return NotFound();
            }

            
            if (id == allQuestions[countOfQuestions].Id)
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
            ViewBag.AllQuestions = allQuestions;
            return View("Result", questionViewModel);
        }

        public IActionResult Explanation(Guid id)
        {
            //var question = questionStorage.GetQuestion(id);
            var question = databaseContext.Questions.FirstOrDefault(question => question.Id == id);
            ViewBag.Explanation = question.Explanation;

            var questionViewModel = new QuestionViewModel()
            {
                Id = question.Id,
                Text = question.Text,
                Options = question.Options.Select(option => new QuestionOptionsViewModel 
                {
                    Id = option.Id,
                    Text = option.Text,
                    QuestionId = option.Id,
                    Question = option.Question
                }).ToList(), // создает новую коллекцию, где каждый элемент - это значение свойства Text из каждого объекта QuestionOptionsМетод ToList преобразует результат работы Select (который является IEnumerable<string>) в List<string>.
                CorrectAnswerIndex = question.CorrectAnswerIndex,
                Explanation = question.Explanation
            };

            return View("Explanation", questionViewModel);
        }

        public IActionResult EndMarathon()
        {
            return View();
        }
    }
}
