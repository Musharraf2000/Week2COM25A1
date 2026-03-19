using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2COM25A1
{
    internal class Student
    {
        public string name;
        public int age;
        public int memberId;
        public string phoneNumber;

        public void PrintStudentInfo(){
            Console.WriteLine($"Name: {name}, Age: {age}, Member ID: {memberId}, Phone Number: {phoneNumber}");
        }

        public void login() {
        
            Console.WriteLine($"{name} has logged in.");

        }
    }
}
