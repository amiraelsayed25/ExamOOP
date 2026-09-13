using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    public class Answers 
    {
        //Attributes
        public int AnswerID {  get; set; }
        public string AnswerText {  get; set; }

        //Constructor
        public Answers(int id, string text)
        {
            AnswerID = id;
            AnswerText = text;
        }

        //Override
        public override string ToString()
        {
            return ($"Answer : {AnswerID}, AnswerText : {AnswerText}");
        }

    }
}
