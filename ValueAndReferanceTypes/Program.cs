using System;

namespace ValueAndReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int num1 = 10;
            int num2 = 30;
            num1 = num2;
            num2 = 65;
            Console.WriteLine(num1);

            int[] numbers1 = new int[] {10, 20, 30 };
            int[] numbers2 = new int[] {100, 200, 300 };

            numbers1 = numbers2;
            numbers2[0] = 999;

            Console.WriteLine(numbers1[0]);
            Console.WriteLine(numbers1[1]);
            Console.WriteLine(numbers1[2]);

            string[] students = new string[3];
            students[0] = "engin";
            students[1] = "derin";
            students[2] = "salih";
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            string[] students2 = { "engin", "derin", "salih"} ;
            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }


        }
    }
}
