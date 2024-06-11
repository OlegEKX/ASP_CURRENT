﻿using ASP_TrafficRules.Db.Models;
using System;

namespace ASP_CURRENT.Models
{
    public class QuestionOptionsViewModel
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public Guid QuestionId { get; set; }
        public Question Question { get; set; }
    }
}