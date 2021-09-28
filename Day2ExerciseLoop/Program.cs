using System;

namespace Day2ExerciseLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            Console.WriteLine("Even Numbers");
            for (int i = 0; i <= 100; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i++);
                }
            }
            
            //Exercise 2
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

            //Exercise 3
            int sum = 0;
            for (int i = 0; i<=5; i++)
            {
                sum += i;                
            }
            Console.WriteLine(sum);
        }
    }
}
