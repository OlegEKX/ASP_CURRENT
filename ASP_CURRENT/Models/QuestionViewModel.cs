using System;
using System.Collections.Generic;

namespace ASP_CURRENT.Models
{
    public class QuestionViewModel
    {
        //private static int unicId = 0;
        public Guid Id { get; set; }   // Уникальный идентификатор вопроса

        public string Text { get; set; }  // Текст вопроса

        public List<QuestionOptionsViewModel> Options { get; set; }/* = new List<QuestionOptionsViewModel>();*/  // Список возможных ответов

        public int CorrectAnswerIndex { get; set; }  // Индекс правильного ответа в списке Options

        public string Explanation { get; set; }  // Пояснение к правильному ответу (необязательное поле)

        /*public QuestionViewModel()
        {
            Options = new List<string>();
        }

        public QuestionViewModel(string text, List<string> options, int correctAnswerIndex, string explanation)
        {
            
            Id = unicId;
            Text = text;
            Options = options;
            CorrectAnswerIndex = correctAnswerIndex;
            Explanation = explanation;
            unicId++;
        }

        public QuestionViewModel(string text, List<string> options, int correctAnswerIndex)
        {
            unicId++;
            Id = unicId;
            Text = text;
            Options = options;
            CorrectAnswerIndex = correctAnswerIndex;
        }*/
    }
}
