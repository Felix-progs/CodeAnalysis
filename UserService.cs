using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAnalysis
{
    public class UserService
    {
        public void AddUser(string name)
        {
            Console.WriteLine("1");
        }
        public void ListUsers()
        {
            Console.WriteLine("2");
        }
        public void RemoveUser(string name)
        {
            Console.WriteLine("3");
        }
        public void SearchUser(string name)
        {
            Console.WriteLine("4");
        }   
    }
}
