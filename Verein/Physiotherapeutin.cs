using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verein
{
    public class Physiotherapeutin
    {
        public string Name { get; private set; }

        public Physiotherapeutin(string name)
        {
            Name = name;
        }

        public void Massieren()
        {
            Console.WriteLine($"{Name} massiert einen Spieler.");
        }
    }

}
