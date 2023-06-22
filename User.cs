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
        string _model;
        string _memory;
        string _brand;

        public User(string firstName, string lastName, string model, string memory, string brand)
        {
            _firstName = firstName;
            _lastName = lastName;
            _model = model;
            _memory = memory;
            _brand = brand;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Model { get => _model; set => _model = value; }
        public string Memory { get => _memory; set => _memory = value; }
        public string Brand { get => _brand; set => _brand = value; }
    }
}
