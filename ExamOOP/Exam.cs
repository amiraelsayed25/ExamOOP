using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    public abstract class Exam : IComparable, ICloneable
{
    public int Time { get; set; }
    public int NumberOfQuestions { get; set; }

    public Question[] Questions { get; set; }

    public Exam(int time, int numberOfQuestions)
    {
        Time = time;
        NumberOfQuestions = numberOfQuestions;
        Questions = new Question[numberOfQuestions];
    }

    public abstract void ShowExam();

    public int CompareTo(object? obj)
    {
        Exam other = (Exam)obj;
        return Time.CompareTo(other.Time);
    }

    public object Clone()
    {
        return this.MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Time: {Time}, Number Of Questions: {NumberOfQuestions}";
    }
}
}