using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab3
{
    internal abstract class MusicPlayer
    {
        string _name;

        public MusicPlayer(string name)
        {
            _name = name;
            
        }

        public string Name { get => _name; set => _name = value; }

        public abstract double ImportSongs(double amount);

        public abstract double DeleteSongs(double amount);
    }

}
