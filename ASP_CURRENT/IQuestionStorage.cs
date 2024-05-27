using ASP_CURRENT.Models;
using System.Collections.Generic;

namespace ASP_CURRENT
{
    public interface IQuestionStorage
    {
        List<Question> allQuestions { get; }

        List<Question> GetAllQuestions();

        Question GetQuestion(int id);
    }
}
