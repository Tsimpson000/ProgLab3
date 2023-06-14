using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab3
{
    internal class User
    {
        string _firstName;
        string _lastName;
        List<User> _user;

        public User(string firstName, string lastName, List<User> user)
        {
            _firstName = firstName;
            _lastName = lastName;
            _user = new List<User>();
        }
    }
}
