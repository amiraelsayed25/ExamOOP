using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    public class PracticalExam : Exam
    {
        public int i;
        public PracticalExam(int time, int number) : base(time, number)
        {
        }
        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam");
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine(Questions[i].BodyOfTheQuestion);
                Console.WriteLine("Answers:");
            }
            foreach (Answers answers in Questions[i].Answers)
            {
                Console.WriteLine(answers);
            }
            Console.WriteLine($"Right Answer: {Questions[i].RightAnswer}");
            
        }
    }
}
