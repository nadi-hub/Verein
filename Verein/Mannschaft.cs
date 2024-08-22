using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verein
{
    public class Mannschaft
    {
        public string Name { get; private set; }
        public List<Torwart> Torhueter { get; private set; }
        public List<Feldspieler> Feldspieler { get; private set; }

        public Mannschaft(string name)
        {
            Name = name;
            Torhueter = new List<Torwart>();
            Feldspieler = new List<Feldspieler>();
        }

        public void AddTorwart(Torwart torwart)
        {
            Torhueter.Add(torwart);
        }

        public void AddFeldspieler(Feldspieler feldspieler)
        {
            Feldspieler.Add(feldspieler);
        }
    }
}
