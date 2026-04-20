using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();

            Console.Write("Enter a grade: ");
            int input = int.Parse(Console.ReadLine());

            course.Grade = input;

            if (course.IsPass)
                Console.WriteLine($"Grade: {course.Grade} -  You Pass! :)");
            else
                Console.WriteLine($"Grade: {course.Grade} - You Fail! :(");
        }
    }
}