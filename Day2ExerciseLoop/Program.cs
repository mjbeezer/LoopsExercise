using System;

namespace Day2ExerciseLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loop Exercise, display evens only back to user
            
            for (int i = 0; i <= 100; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i++);
                }
            }
        }
    }
}
