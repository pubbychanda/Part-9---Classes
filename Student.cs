using System;
using System.Collections.Generic;
using System.Text;

namespace Part_9___Classes
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string email;
        private static Random rng = new Random();
        private int studentNumber;


        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            studentNumber = rng.Next(100, 1000) + 555000;
            GenerateEmail();

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
                GenerateEmail();
            }
           
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                this.lastName = value;
                GenerateEmail();
            }
           
        }

        public int StudentNumber
        {
            get
            {
                return studentNumber;
            }

        }

        public string Email
        {
            get
            {
                return email;
            }
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }

        //public void ResetStudentNumber()
        //{
        //    studentNumber = 555000;
        //    studentNumber += rng.Next(100, 1000);
        //}

        private void GenerateEmail()
        {
            email = firstName.Substring(0, 3) + lastName.Substring(0, 3) + studentNumber.ToString().Substring(3) + "@ICS4U.com";
        }
    }
}
