using System;

namespace Array_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //array type int, named grade, and it has space for 5 items in the array
            int[] grades = new int[5];

            //set value at each index in the array
            grades[0] = 100;
            grades[1] = 75;
            grades[2] = 80;
            grades[3] = 35;
            grades[4] = 70;

            Console.WriteLine("Grades at index 0 : {0}", grades[0]);
        }
    }
}
