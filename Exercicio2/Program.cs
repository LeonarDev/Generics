using System;
using System.Collections.Generic;
using Exercicio2.Entities;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> course = new HashSet<Student>();

            Console.Write("How many students for course A? ");
            int nCourseA = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nCourseA; i++)
            {
                Console.Write($"Code of student {i}: ");
                int studentCode = int.Parse(Console.ReadLine());
                course.Add(new Student { Code = studentCode });

            }

            Console.Write("How many students for course B? ");
            int nCourseB = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nCourseB; i++)
            {
                Console.Write($"Code of student {i}: ");
                int studentCode = int.Parse(Console.ReadLine());
                course.Add(new Student { Code = studentCode });
            }

            Console.Write("How many students for course C? ");
            int nCourseC = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nCourseC; i++)
            {
                Console.Write($"Code of student {i}: ");
                int studentCode = int.Parse(Console.ReadLine());
                course.Add(new Student { Code = studentCode });
            }

            Console.WriteLine($"Total students: {course.Count}");
        }
    }
}
