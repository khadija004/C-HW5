using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW5
{
    internal class Admin:User
    {
        public bool IsSuperAdmin { get; set; }
        public string Section { get; set; }

        public Admin(bool isSuperAdmin,string section, string _username, string _password):base(_username, _password)
        {
            IsSuperAdmin = isSuperAdmin;
            Section = section;
        }

        public void GetInformation()
        {
            Console.WriteLine($"Username is: {Username}");
            Console.WriteLine($"Password is: {Password}");
            Console.WriteLine($"User section is: {Section}");
            if (IsSuperAdmin)
            {
                Console.WriteLine("You are SuperAdmin");
            }
            else
            {
                Console.WriteLine("You are not a SuperAdmin");
            }
        }
    }
}
