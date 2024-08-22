using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Verein

{
    internal class Verein
    {
        public Verein() {
        }
    
    public Verein(string name, Präsident praesident)
    {
        Name = name;
        Praesident = praesident;
        Mannschaften = new List<Mannschaft>();
        Physiotherapeutin = physiotherapeutin;
    }

    public void AddMannschaft(Mannschaft mannschaft)
    {
        Mannschaften.Add(mannschaft);
    }

    public void AddPhysiotherapeutin(Physiotherapeutin physiotherapeutin)
    {
        Physiotherapeutin.Add(physiotherapeutin);
    }
}
