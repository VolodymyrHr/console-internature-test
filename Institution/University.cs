using InternshipTest.Person;
using System.Linq;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
    public class University
    {
        string name;
        private List<Student> studentList = new List<Student>();

        public University(string name)
        {
            this.name = name;
        }

        public void AddStudent(Student student)
        {
             studentList.Add(student);
        }

        public int GetEverage(){
            int num = studentList.Count();
            int sum = studentList.Sum(student => student.GetKnowledge().GetLevel());
            return sum/num;
        }

        public List<Student> GetStudents(){
            return studentList;
        }

        public string GetName(){
            return name;
        }

    }
}