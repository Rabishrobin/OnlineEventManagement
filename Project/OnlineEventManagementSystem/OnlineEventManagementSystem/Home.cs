using System;

namespace OnlineEventManagementSystem
{
    static class Home
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter your choice \n1.User \n3.Admin \n4.Exit");
                ConsoleKey choiceKey = Console.ReadKey().Key;
                Console.ReadLine();
                if (choiceKey == ConsoleKey.D1)
                {
                    Repository userRepository = new Repository();
                }
                else if (choiceKey == ConsoleKey.D3)
                {
                    Admin admin = new Admin();
                }
                else if(choiceKey == ConsoleKey.D4)
                    break;
                else
                    Console.WriteLine(" Invalid choice");
            }
        }
    }
}
