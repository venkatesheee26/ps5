using System;
namespace day4ass5
{
    internal class program
    {
        static void Main(string[] args)
        {
            int maxAttempts = 3;
            int attempts = 0;
            string username = "john";
            string password = "pass123";

            while (attempts < maxAttempts)
            {
                Console.WriteLine("Please enter your username: ");
                string inputUsername = Console.ReadLine();

                Console.WriteLine("Please enter your password: ");
                string inputPassword = Console.ReadLine();

                if (inputUsername == username && inputPassword == password)
                {
                    Console.WriteLine("Login successful.");
                    break;
                }
                else if (inputUsername == username && inputPassword != password)
                {
                    Console.WriteLine("Invalid password.");
                }
                else
                {
                    Console.WriteLine("Invalid username.");
                }

                attempts++;
            }

            if (attempts == maxAttempts)
            {
                Console.WriteLine("Login failed.");
            }
        }
    }
}

