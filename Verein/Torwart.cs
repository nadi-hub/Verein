using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verein
{
    public class Torwart
    {
        public string Name { get; private set; }

        public Torwart(string name)
        {
            Name = name;
        }

        public void BallHalten()
        {
            Console.WriteLine($"{Name} hält den Ball.");
        }
    }
}
