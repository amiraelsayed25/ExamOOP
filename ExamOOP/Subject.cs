using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    public class Subject
    {
        //Attributes
        public int Id { get; set; }
        public string Name { get; set; }
        public string ExamOfTheSubject {  get; set; }
        public Exam Exam {  get; set; }
        
         public Subject(int id, string name, string examOfTheSubject)
          {
            Id = id;
            Name = name;
            ExamOfTheSubject= examOfTheSubject;
          }

        public void CreateExam(Exam exam)
        {
            Exam = exam;
        }
        public override string ToString()
        {
            return ($"Subject ID: {Id}, Subject Name :{Name}");
        }

    }
}
