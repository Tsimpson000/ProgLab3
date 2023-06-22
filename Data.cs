using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab3
{
    class Data
    {
        static ObservableCollection<User> _users;
        static Data()
        {
            _users = new ObservableCollection<User>();
        }
        internal static ObservableCollection<User> Users { get => _users; set => _users = value; }

        public static void AddUserToCollection(User user)
        {
            _users.Add(user);
        }
    }
}
