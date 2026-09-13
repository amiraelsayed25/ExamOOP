using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    public class TFQuestion : Question
    {

  
            public TFQuestion(string headerOfTheQuestion, string bodyOfTheQuestion, int mark, Answers rightAnswer)
                : base( headerOfTheQuestion, bodyOfTheQuestion, mark, new Answers[] { new Answers(1, "True"), new Answers(2, "False") }, rightAnswer)
            {
            }
        }
    }

