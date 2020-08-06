using System;

namespace InternshipTest.Person

{
    public class Student
    {
        string name;
        Knowledge knowledge;

        public Student(string name, Knowledge knowledge)
        {
            this.name = name;
            this.knowledge = knowledge;
        }

        public string GetStudentName(){
            return name;
        }
        public Knowledge GetKnowledge(){
            return knowledge;
        }

    }
}