using System.Collections.Generic;

namespace ASP_CURRENT.Models
{
    public class Question
    {
        private static int unicId = 0;
        public int Id { get; set; }   // Уникальный идентификатор вопроса

        public string Text { get; set; }  // Текст вопроса

        public List<string> Options { get; set; }  // Список возможных ответов

        public int CorrectAnswerIndex { get; set; }  // Индекс правильного ответа в списке Options

        public string Explanation { get; set; }  // Пояснение к правильному ответу (необязательное поле)

        public Question()
        {
            Options = new List<string>();
        }

        public Question(string text, List<string> options, int correctAnswerIndex, string explanation)
        {
            
            Id = unicId;
            Text = text;
            Options = options;
            CorrectAnswerIndex = correctAnswerIndex;
            Explanation = explanation;
            unicId++;
        }

        public Question(string text, List<string> options, int correctAnswerIndex)
        {
            unicId++;
            Id = unicId;
            Text = text;
            Options = options;
            CorrectAnswerIndex = correctAnswerIndex;
        }
    }
}
