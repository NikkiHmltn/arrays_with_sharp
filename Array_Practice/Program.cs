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
            // assign value to array grades at index 0 
            //string input = Console.ReadLine();
            //grades[0] = int.Parse(input);

            //Console.WriteLine("Grades at index 0 : {0}", grades[0]);

            //another way to initialize an array
            int[] gradesMath = { 20, 13, 12, 8, 8, 10 };

            //third way to initialize an array
            int[] gradesEnglish = new int[] { 14, 20, 10, 10, 12, 14, 19 };

            //length of array
            Console.WriteLine("Length of grades is " + gradesMath.Length);

            //for loop with array
            int[] nums = new int[10];

            for(int i = 0; i < 10; i++)
            {
                nums[i] = i;
            }

            for(int j = 0; j <10; j++)
            {
                Console.WriteLine("Element{0} = {1}", j, nums[j]);
            }
        }
    }
}
