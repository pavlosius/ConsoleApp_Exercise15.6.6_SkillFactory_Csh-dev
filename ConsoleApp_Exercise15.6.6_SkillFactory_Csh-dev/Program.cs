using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));

            Console.WriteLine("Программа завершена. Нажмите любую клавишу...");
            Console.ReadKey();
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            string[] result = classes.SelectMany(c => c.Students).ToArray();
            return result;
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}