using System;

namespace NotificationsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int option = 4;

            do
            {
                Console.WriteLine();
                Console.WriteLine("1 - Messages");
                Console.WriteLine("2 - Friendship Requests");
                Console.WriteLine("3 - Global Notifications");
                Console.WriteLine("4 - Exit");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("8 new messages");
                        break;
                    case 2:
                        Console.WriteLine("3 friendship requests");
                        break;
                    case 3:
                        Console.WriteLine("2 global notifications");
                        break;
                }

            } while(option != 4);
        }
    }
}
