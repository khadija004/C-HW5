using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW5
{
    internal class User
    {
        public string Username
        {
            get
            {
                return username;
            }
            set
            {

                if (value.Length > 6)
                {
                    username = value;
                }
                else
                {
                    while (value.Length < 6)
                    {
                        Console.WriteLine("Enter valid username");
                        value = Console.ReadLine();
                    }
                    username = value;
                }
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if(value.Any(char.IsDigit) && value.Any(char.IsUpper))
                {
                    password = value;
                }
                else
                {
                    while (!value.Any(char.IsDigit) || !value.Any(char.IsUpper))
                    {
                        Console.WriteLine("Enter valid password");
                        value=Console.ReadLine();
                    }
                    password=value;
                }
            }
        }

        string username;
        string password;
        public User(string _username, string _password)
        {
            Username = _username;
            Password = _password;

        }
    }
}
