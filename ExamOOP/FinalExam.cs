//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ExamOOP
//{
//    public class FinalExam : Exam
//    {
//        public int i;
//        public FinalExam(int time, int number)
//            : base(time, number)
//        {
//        }

//        public override void ShowExam( )
//        {
//            Console.WriteLine("Final Exam");
//            for (int i = 0; i < Questions.Length; i++)
//            {
//                Console.WriteLine(Questions[i].BodyOfTheQuestion);
//                Console.WriteLine("Answers:");
//            }
//            if (Questions[i]?.Answers!=null)
//            {
//                foreach (Answers answers in Questions[i].Answers)
//                {
//                    Console.WriteLine(answers);
//                }
//            }
//            Console.WriteLine($"Right Answer: {Questions[i].RightAnswer}");
//            Console.WriteLine($"Grade :{Questions[i].Mark}");

//        }
//    }
//}
