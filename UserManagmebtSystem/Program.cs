using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagmebtSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new UserManager();
            manager.AddUser("test");
            Console.WriteLine(manager.RemoveUser("test")); // Должно вывести True
        }
    }
}
