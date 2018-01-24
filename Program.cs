using System;

namespace sumAverageCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();

            var number = 0;
            var counter = 10;
            for (int i = 0; i < counter; i++)
            {
            Console.Write("Please enter in a number: ");
            int userInput = int.Parse(Console.ReadLine());
            number += userInput;
            }
            Console.Write("the sum is: " + number);
            Console.WriteLine("average is: " + number/counter);


            /*double total = 0;
            for (int i = 1; i <= 4; i++)
            {
                Console.Write("Please enter a number: ");
                total += Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("The sum is: ");
            Console.WriteLine(total.ToString());
            Console.Write("The average is: ");
            Console.WriteLine((total / 4).ToString());*/


            /*int counter = 4;
            int userInput = 0;
            for (int i = 1; i <= counter; i++)
            {
                Console.Write("Please enter a number: ");
                userInput += int.Parse(Console.ReadLine());
            }
            Console.Write("The sum is: ");
            Console.WriteLine(userInput);
            Console.Write("The average is: ");
            Console.WriteLine((userInput / counter));*/
            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
