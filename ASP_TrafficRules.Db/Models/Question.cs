using System;
using System.Collections.Generic;

namespace ASP_TrafficRules.Db.Models
{
    public class Question
    {
        public Guid Id { get; set; }   // Уникальный идентификатор вопроса

        public string Text { get; set; }  // Текст вопроса

        //public List<QuestionOptions> QuestionOptions { get; set; }/* = new List<QuestionOptions>();*/  // Список возможных ответов

        public int CorrectAnswerIndex { get; set; }  // Индекс правильного ответа в списке Options

        public string Explanation { get; set; }  // Пояснение к правильному ответу (необязательное поле)

        public ICollection<QuestionOptions> QuestionOptions { get; set; }

        public Question() { }


        public Question(string text, List<string> options, int correctAnswerIndex, string explanation)
        {
            Id = Guid.NewGuid();
            Text = text;
            QuestionOptions = new List<QuestionOptions>();  // Инициализация списка

            // Добавление каждого варианта ответа в список Options
            foreach (var option in options)
            {
                QuestionOptions.Add(new QuestionOptions(option, Id));
            }

            CorrectAnswerIndex = correctAnswerIndex;
            Explanation = explanation;
        }



        
    }
}
