using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    public class MCQQuestion : Question
    {
        public MCQQuestion(string headerOfTheQuestion, string bodyOfTheQuestion, int mark, Answers[] answers,Answers rightAnswer)
            : base(headerOfTheQuestion, bodyOfTheQuestion, mark, answers, rightAnswer)
        {
        }
    }
}
