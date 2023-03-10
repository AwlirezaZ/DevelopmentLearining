using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04
{
    public class Student
    {
        //fields
        private string _fullName;
        private DateTime _signUpDate;
        private string _fatherName;
        private bool _isPresent;

        //constructor
        public Student(string fullName)
        {
            _fullName = fullName;
            _signUpDate = DateTime.Now;
            WritePresenceOfStudentToHerProfile(true);
        }

        public void SetFatherName(string fatherName)
        {
            _fatherName = fatherName;
        }

        public string GetFatherName()
        {
            return _fatherName;
        }

        private void WritePresenceOfStudentToHerProfile(bool isPresent)
        {
            _isPresent = isPresent;
        }

        public void PrintAllInfo()
        {
            Console.WriteLine($"Full Name : {_fullName}");
            Console.WriteLine($"SignUp Date: {_signUpDate}");
        }

        public static void Test()
        {

        }
    }

}
