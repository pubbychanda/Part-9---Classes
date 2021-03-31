using System;
using System.Collections.Generic;

namespace Part_9___Classes
{
    class Program
    { 

        static void Main(string[] args)
        {
            string firstName;
            string lastName;


            List<Student> students = new List<Student>();
            students.Add(new Student("robert", "rossington"));
            students.Add(new Student("Charlie", "Peters"));
            students.Add(new Student("Dennis", "Dalewood"));
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Please enter a first name: ");
                firstName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Please enter their last name: ");
                lastName = Convert.ToString(Console.ReadLine());
                students.Add(new Student(firstName, lastName));
            }
            for (int i = 0; i < students.Count; i++)
            {
                students.Sort();
                Console.WriteLine(students[i].Email + " | " + students[i].StudentNumber); 
            }

        }
    }
}
