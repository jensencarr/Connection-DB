using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection_DB
{
    public class Users
    {
        public string fullname;
        public string username;
        public string password;
        public string email;
        public string DoB;

        public void RegisterUser()
        {
            Console.Write("Full Name: ");
            fullname = Console.ReadLine();
            Console.Clear();

            Console.Write("Username: ");
            username = Console.ReadLine();
            Console.Clear();

            Console.Write("Password: ");
            password = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Email: ");
            email = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Date of Birth (Like this ->[xxxx-xx-xx]");
            DoB = Console.ReadLine();
            Console.Clear();
        }
    }
}
