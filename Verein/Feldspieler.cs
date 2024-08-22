using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verein
{
    public class Feldspieler
    {
        public string Name { get; private set; }

        public Feldspieler(string name)
        {
            Name = name;
        }

        public void Schiessen()
        {
            Console.WriteLine($"{Name} schießt den Ball.");
        }

        public void Grätschen()
        {
            Console.WriteLine($"{Name} grätscht.");
        }
    }
}
