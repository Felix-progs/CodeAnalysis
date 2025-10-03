using CodeAnalysis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAnalysis
{
    public class UserService
    {
        private readonly List<User> users = new();
        public void AddUser(string name)
        {
            users.Add(new User { Name = name });
            Console.WriteLine($"Personen: {name} är nu i listan");
        }
        public void ListUsers()
        {
            Console.WriteLine("Användare:");
            if (users.Count == 0)
            {
                Console.WriteLine("Inga användare hittades.");
                return;
            }
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
        }
        public void RemoveUser(string name)
        {
            User userToRemove = null;

            foreach (var user in users)
            {
                if (user.Name == name)
                {
                    userToRemove = user;
                    break;
                }
            }

            if (userToRemove != null)
            {
                users.Remove(userToRemove);
                Console.WriteLine($"Personen: {name} är nu borttagen");
            }
            else
            {
                Console.WriteLine($"Personen: {name} hittades inte ");
            }
        }

        public void SearchUser(string name)
        {
            bool found = false;

            foreach (var user in users)
            {
                if (user.Name == name)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine($"Personen: {name} finns i listan");
            else
                Console.WriteLine($"Personen: {name} hittades inte i listan");
        }
    }
}
