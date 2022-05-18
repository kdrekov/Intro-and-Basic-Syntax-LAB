using System;

namespace Intro_and_Basic_Syntax_LAB
{
    class StudentInformation
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var age = Console.ReadLine();
            var grade = Console.ReadLine();
            Console.WriteLine("Name: {0}, Age: {1}, Grade: {2}", name, age, grade);
        }
    }
}
