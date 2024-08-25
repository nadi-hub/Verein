using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verein
{
    public class Mannschaft

        
    {
        /// <summary>
        /// Diese Funktion dient zur Prüfung des Automodelles und Marke. 
        ///param = Marke, Model, Jahr
        /// </summary>
        public string Name { get; private set; }
        public List<Torwart> Torhueter { get; private set; }
        public List<Feldspieler> Feldspieler { get; private set; }

        public Mannschaft(string name)
        {
            Name = name;
            Torhueter = new List<Torwart>();
            Feldspieler = new List<Feldspieler>();
        }
        /// <summary>
        /// Diese Funktion dient zur Prüfung des Automodelles und Marke. 
        /// </summary>
        /// <param name="torwart"></param>
        public void AddTorwart(Torwart torwart)
        {
            Torhueter.Add(torwart);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="feldspieler"></param>
        public void AddFeldspieler(Feldspieler feldspieler)
        {
            Feldspieler.Add(feldspieler);
        }
    }
}
