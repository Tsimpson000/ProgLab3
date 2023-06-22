using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab3
{
    internal class Ipod : MusicPlayer
    {
        string _model;
        double _memory;

        public Ipod (string name, string model, double memory) : base(name)
        {
            _memory = memory;
            _model = model;
        }

        public override double ImportSongs(double amount)
        {
            double currentStorage;
            double songMemory = .1;
            currentStorage = _memory - amount * songMemory;
            return currentStorage;
        }

        public override double DeleteSongs(double amount)
        {
            double currentStorage;
            double songMemory = .1;
            currentStorage = _memory + amount * songMemory;
            return currentStorage;

        }

        public override string ToString()
        {
            return base.ToString() +  $"{_model} {_memory}gb - ";
        }
    }
}
