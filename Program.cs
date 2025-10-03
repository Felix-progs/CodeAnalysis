using System;
using CodeAnalysis;
namespace CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        var userService = new UserService();
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
            switch (choice)
            {
                case "1":
                    Console.Write("Ange namn: ");
                    string nameToAdd = Console.ReadLine();
                    userService.AddUser(nameToAdd);
                    break;

                case "2":
                    userService.ListUsers();
                    break;

                case "3":
                    Console.Write("Ange namn för att ta bort: ");
                    string nameToRemove = Console.ReadLine();
                    userService.RemoveUser(nameToRemove);
                    break;

                case "4":
                    Console.Write("Ange namn för att söka: ");
                    string nameToSearch = Console.ReadLine();
                    userService.SearchUser(nameToSearch);
                    break;

                case "5":
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
