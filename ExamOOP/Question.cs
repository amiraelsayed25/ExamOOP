using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    public abstract class Question
    {

        //Attributes
        public string HeaderOfTheQuestion { get; set; }
        public string BodyOfTheQuestion { get; set; }
        public int Mark { get; set; }

        //Array
        public Answers[] Answers { get; set; } //List
        public Answers RightAnswer { get; set; }   //RightAnswer
        public Answers UsweAnswer { get; set; }   //UserAnswer




        //Constructor
        public Question(string headerOfTheQuestion, string bodyOfTheQuestion, int mark, Answers[]answers,Answers rightAnswer)
        {
            HeaderOfTheQuestion = headerOfTheQuestion;
            BodyOfTheQuestion = bodyOfTheQuestion;
            Mark = mark;
            Answers = answers;
            RightAnswer = rightAnswer;
        }

        public override string ToString()
        {
            return ($"  Header :{HeaderOfTheQuestion}  ,Body :{BodyOfTheQuestion}, Mark :{Mark} ");
        }




    }
}
