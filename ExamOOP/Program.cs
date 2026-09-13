//using System.Diagnostics;

//namespace ExamOOP
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //Console.WriteLine("Hello, World!");

//            // 1. مرحلة إدخال بيانات الامتحان والأسئلة 
//            Console.Write("Enter the type of exam (1 for Practical, 2 for Final): ");
//            int examType = int.Parse(Console.ReadLine());

//            Console.Write("Please enter the time for the exam (30 to 180 minutes): ");
//            int time = int.Parse(Console.ReadLine());

//            Console.Write("Please enter the number of questions: ");
//            int numberOfQuestions = int.Parse(Console.ReadLine());

//            Console.Clear();

//            Question[] questions = new Question[numberOfQuestions];

//            for (int i = 0; i < numberOfQuestions; i++)
//            {
//                Console.WriteLine("Please enter the question body:");
//                string body = Console.ReadLine();

//                Console.WriteLine("Please enter the question mark:");
//                int mark = int.Parse(Console.ReadLine());

//                Console.WriteLine("Choices of Question:");
//                Answers[] answersList = new Answers[4];

//                for (int j = 0; j < 4; j++)
//                {
//                    Console.Write($"Please enter choice number {j + 1}:\n");
//                    string choiceText = Console.ReadLine();
//                    answersList[j] = new Answers(j + 1, choiceText);
//                }

//                Console.WriteLine("Specify the correct choice ID:");
//                int rightChoiceId = int.Parse(Console.ReadLine());
//                Answers rightAnswer = answersList[rightChoiceId - 1];

//                // إنشاء السؤال وعمل الخيارات والإجابة الصحيحة بالكامل
//                questions[i] = new MCQQuestion("MCQ Question:", body, mark, answersList, rightAnswer);

//                // خطوة إضافية لتأكيد  الإجابة الصحيحة وتجنب الـ NullReferenceException
//                questions[i].RightAnswer = rightAnswer;

//                Console.Clear();
//            }

//            // 2. مرحلة بدء الامتحان للطالب (Student Mode)
//            Console.Write("Do You Want To Start Exam (Y | N)\n");
//            char start = char.Parse(Console.ReadLine());

//            if (char.ToUpper(start) == 'Y')
//            {
//                Console.Clear();

//                Stopwatch timer = new Stopwatch();
//                timer.Start();

//                int totalGrade = 0;
//                int userGrade = 0;
//                Answers[] studentAnswers = new Answers[numberOfQuestions];

//                string examTitle = (examType == 1) ? "Practical Exam" : "Final Exam";
//                Console.WriteLine(examTitle);

//                for (int i = 0; i < questions.Length; i++)
//                {
//                    totalGrade += questions[i].Mark;

//                    Console.WriteLine($"Question {i + 1}: {questions[i].BodyOfTheQuestion}");
//                    Console.WriteLine($"{questions[i].HeaderOfTheQuestion}   Mark {questions[i].Mark}");

//                    for (int j = 0; j < questions[i].Answers.Length; j++)
//                    {
//                        Console.WriteLine($"{questions[i].Answers[j].AnswerID}- {questions[i].Answers[j].AnswerText}");
//                    }

//                    Console.WriteLine("Enter your answer ID:");
//                    int studentChoiceId = int.Parse(Console.ReadLine());

//                    studentAnswers[i] = questions[i].Answers[studentChoiceId - 1];

//                    // التحقق من الإجابة الصحيحة
//                    if (studentChoiceId == questions[i].RightAnswer.AnswerID)
//                    {
//                        userGrade += questions[i].Mark;
//                    }

//                    Console.WriteLine("----------------------------------");
//                }

//                timer.Stop();
//                Console.Clear();

//                // 3. عرض النتيجة والتقرير النهائي
//                Console.WriteLine($"{examTitle} Results:");

//                for (int i = 0; i < questions.Length; i++)
//                {
//                    Console.WriteLine($"Question {i + 1}: {questions[i].BodyOfTheQuestion}");
//                    Console.WriteLine($"Your Answer => {studentAnswers[i].AnswerText}");
//                    Console.WriteLine($"Correct Answer => {questions[i].RightAnswer.AnswerText}\n");
//                }

//                Console.WriteLine($"Your Grade is {userGrade} from {totalGrade}");
//                Console.WriteLine($"Time = {timer.Elapsed}");
//                Console.WriteLine("Thank you");
//            }
//        }
//    }
//}



