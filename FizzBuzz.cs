clusing Internal;
using System;

class ConsoleUI
{
    static void Main(string[] args)
    {
        
        int number = 0;
        bool parsed = false;

        Console.Write("Enter your number: ");
        do
        {
            string userInput = Console.ReadLine();
            parsed = int.TryParse(userInput, out number); 

            if (!parsed)
            {
                Console.WriteLine("Input invalid. Try Again.");
            }

        } while (!parsed);

        Console.Clear();
        
        if (number % 3 == 0 && number % 5 != 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (number % 3 != 0 && number % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else if (number % 3 == 0 && number % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else
        {
            Console.WriteLine("Something happened.");
        }
        
    }
}