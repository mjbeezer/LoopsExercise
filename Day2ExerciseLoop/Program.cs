using System;

namespace Day2ExerciseLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loop Exercise, display even and odd numbers back to user. Even numbers first. Odd numbers second.
            Console.WriteLine("Even Numbers");
            for (int i = 0; i <= 100; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i++);
                }
            }
            
            //While Loop Exercise
            bool runProgram = true;
            
            while (runProgram)
            {
                Console.WriteLine("Do you want to continue looping? y/n");
                string programCheck = Console.ReadLine();
                if(programCheck == "y")
                {
                    runProgram = true;
                }
                else if(programCheck == "n")
                {
                    runProgram = false;
                }
            }
        }
    }
}
