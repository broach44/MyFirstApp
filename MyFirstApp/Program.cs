using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter your name...");
            var userEntry = Console.ReadLine();

            Console.WriteLine(userEntry);

            if (userEntry == "Nathan")
            {
                Console.WriteLine("You are awesome");
            }
            else
            {
                Console.WriteLine("You are awesome, but not as much");
            }

            var someNum = 0;
            while (someNum < 10)
            {
                Console.WriteLine($"Current value of someNum is {someNum++}...");
            }

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Current value of i is {i}...");
            }

            foreach (var currentCharacter in userEntry)
            {
                 if (currentCharacter == 'n' || currentCharacter == 'N')
                 {
                    continue;
                 }
                Console.WriteLine($"the current character is {currentCharacter}");
            }

            switch (userEntry)
            {
                case "Nathan":
                    Console.WriteLine("It's Nathan");
                    break;

                default:
                    Console.WriteLine("It's Anything but Nathan");
                    break;
            }

            var isNathan = userEntry == "Nathan" ? true : false;

            Console.WriteLine(isNathan);

            try
            {
                var y = 0;
                var x = 1 / y;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            Console.ReadLine();
        }
    }
}
