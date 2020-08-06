using System.Collections.Generic;
using InternshipTest.Person;
using System;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        private string name;
        private List<Student> students;
        private int everageLevel;

        public Internship(string name,  List<Student> students, int everageLevel)
        {
            this.name = name;  
            this.students = students;   
            this.everageLevel = everageLevel;   
        }

        public void GetInterns()
        {
            var test = FilterStudents();
            test.ForEach(student => Console.WriteLine(student.GetStudentName()));
        }

        public List<Student> FilterStudents(){
            return students.FindAll(student => student.GetKnowledge().GetLevel() >= everageLevel);
        }


    }
}
