using System;

public class SmartQueue
{
    public static void Main()
    {
        Queue <Client> queue = new Queue<Client>();
        int nextId = 1;
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
                    Console.WriteLine("Enter the name of the client: ");
                    string ClientName = Console.ReadLine() ?? string.Empty;

                    Console.WriteLine("Enter the motive of the client: ");
                    string ClientMotive = Console.ReadLine() ?? string.Empty;

                    Client newClient = new Client(nextId, ClientName, ClientMotive);

                    queue.Enqueue(newClient);
                    nextId++;
                    Console.WriteLine($"Client #{nextId - 1} added to the queue.");

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