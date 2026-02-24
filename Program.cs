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
            int.TryParse(Console.ReadLine(), out option);

            if (option == 0) break;
            
        }

        
    }
}