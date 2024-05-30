using ASP_TrafficRules.Db.Models;
using System;
using System.Collections.Generic;

namespace ASP_TrafficRules.Db
{
    public interface IQuestionStorage
    {
        List<Question> allQuestions { get; }

        List<Question> GetAllQuestions();

        Question GetQuestion(Guid id);
    }
}
