using System;

public class SmartQueue
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("=== SmartQueue Manager ===");
            Console.WriteLine("1. Add client");
            Console.WriteLine("2. Attend next client");
            Console.WriteLine("3. View queue");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Select an option: ");
            int option = 0;
            string input = Console.ReadLine();
            if (!int.TryParse(input, out option))
            {
                Console.WriteLine("Invalid option, try again.");
                continue;
            }

            switch(option)
            {
                case 1:
                    Console.WriteLine("Coming soon...");
                    break;
                case 2:
                    Console.WriteLine("Coming soon...");
                    break;
                case 3:
                    Console.WriteLine("Coming soon...");
                    break;
                case 0:
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option, try again");
                    break;
            }
            
        }
    }
}