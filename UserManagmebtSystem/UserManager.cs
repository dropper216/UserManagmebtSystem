using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagmebtSystem
{
    public class UserManager
    {
        List _users = new List();

        public void AddUser(string username)
        {
            _users.Add(username);
        }
    }
}
