using System;
using System.Collections.Generic;
using System.Text;

namespace Part_9___Classes
{
    class Student
    {
        private string firstName;
        private string lastName;
        private static Random rng = new Random();
        private static int studentNumber = 555000;


        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            studentNumber += rng.Next(100, 1000);

        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
    }
}
