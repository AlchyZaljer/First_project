using System;

namespace First_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello :3");
            Console.WriteLine("Please introduce yourself!");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine($"Nice to meet you, {name} {surname}!");
            Console.WriteLine("Select your today mood: ");
            Console.WriteLine("    1) Exallent!");
            Console.WriteLine("    2) Fine");
            Console.WriteLine("    3) Could be beteer");
            Console.Write("Your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
                Console.WriteLine("Glad to hear it!");
            if (choice == 2)
                Console.WriteLine("That's great!");
            if (choice == 3)
                Console.WriteLine("Everything will be fine, hold on!");
            Console.WriteLine("Have a nice day :)");   
            Console.ReadKey();
        }
    }
}
