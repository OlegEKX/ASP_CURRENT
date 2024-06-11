using System;
using System.Collections.Generic;
using System.Text;

namespace ASP_TrafficRules.Db.Models
{
    public class QuestionOptions
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public Guid QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
