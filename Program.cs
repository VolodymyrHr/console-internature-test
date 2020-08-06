using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student("Alex", new Knowledge(3));
            University university = new University("CH.N.U.");
            university.AddStudent(new Student("Andrew Kostenko", new Knowledge(100)));
            university.AddStudent(new Student("Julia Veselkina", new Knowledge(75)));
            university.AddStudent(new Student("Maria Perechrest", new Knowledge(92)));
            university.AddStudent(new Student("Kate Ogirenko", new Knowledge(65)));

            Internship internship = new Internship("Interlink", university.GetStudents(), university.GetEverage());
            Console.WriteLine($"List of internship's students from {university.GetName()} university");
            internship.GetInterns();
        }
    }
}
