using System;

namespace CodeAnalysis;

class Program
{
    static string[] users = new string[10];
    static int totalUsers = 0;

    static void Main(string[] args)
    {
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1. Lägg till användare");
            Console.WriteLine("2. Visa alla användare");
            Console.WriteLine("3. Ta bort användare");
            Console.WriteLine("4. Sök användare");
            Console.WriteLine("5. Avsluta");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Ange namn: ");
                string user = Console.ReadLine();
                if (totalUsers < 10)
                {
                    users[totalUsers] = user;
                    totalUsers++;
                }
                else
                {
                    Console.WriteLine("Listan är full!");
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("Användare:");
                for (int i = 0; i < totalUsers; i++)
                {
                    Console.WriteLine(users[i]);
                }
            }
            else if (choice == "3")
            {
                Console.Write("Ange namn att ta bort: ");
                string nameToRemove = Console.ReadLine();
                int indexToRemove = -1;
                for (int i = 0; i < totalUsers; i++)
                {
                    if (users[i] == nameToRemove)
                    {
                        indexToRemove = i;
                        break;
                    }
                }

                if (indexToRemove != -1)
                {
                    for (int i = indexToRemove; i < totalUsers - 1; i++)
                    {
                        users[i] = users[i + 1];
                    }
                    totalUsers--;
                }
                else
                {
                    Console.WriteLine("Användaren hittades inte.");
                }
            }
            else if (choice == "4")
            {
                Console.Write("Ange namn att söka: ");
                string searchName = Console.ReadLine();
                bool found = false;
                for (int i = 0; i < totalUsers; i++)
                {
                    if (users[i] == searchName)
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    Console.WriteLine("Användaren finns i listan.");
                }
                else
                {
                    Console.WriteLine("Användaren hittades inte.");
                }
            }
            else if (choice == "5")
            {
                isRunning = false;
            }
            else
            {
                Console.WriteLine("Ogiltigt val.");
            }
            Console.WriteLine();
        }
    }
}
