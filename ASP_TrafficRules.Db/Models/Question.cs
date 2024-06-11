using System;
using System.Collections.Generic;

namespace ASP_TrafficRules.Db.Models
{
    public class Question
    {
        public Guid Id { get; set; }   // Уникальный идентификатор вопроса

        public string Text { get; set; }  // Текст вопроса

        public List<QuestionOptions> Options { get; set; }/* = new List<QuestionOptions>();*/  // Список возможных ответов

        public int CorrectAnswerIndex { get; set; }  // Индекс правильного ответа в списке Options

        public string Explanation { get; set; }  // Пояснение к правильному ответу (необязательное поле)
    }
}
