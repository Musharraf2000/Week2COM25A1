using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2COM25A1
{
    internal class ExamStudent
    {
        public string name;
        public List<int> grades = new List<int>(); //[45,34,12,45,6]
        public double average;

        public void AddGrade(int grade) {
            grades.Add(grade);
            Console.WriteLine("Grade added");
        }

        public void GetAverage()
        {
            if(grades.Count == 0) {
                Console.WriteLine("No grades available to calculate average.");
            }
            else
            {
                int count = grades.Count;
                int sum = 0;
                foreach(int grade in grades) {
                    sum += grade; // sum = sum + grade;
                }
                 average = Convert.ToDouble(sum/count);
            }
            
        }

        public void PrintInfo() {
            if(grades.Count == 0 || average == null)
            {
                Console.WriteLine("Add some grades and calculate average first");
                return;
            
            }
            Console.WriteLine($"Name: {name}, Average Grade: {average}");
            if (average >= 60) {
                Console.WriteLine("Status: Passed");

            }
            else
            {
                Console.WriteLine("Status: Failed");
            }
                
        }
    }
}
