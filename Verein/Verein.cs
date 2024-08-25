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
    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="praesident"></param>
    public Verein(string name, Praesident praesident)
    {
        Name = name;
        Praesident = praesident;
        Mannschaften = new List<Mannschaft>();
        Physiotherapeutin = physiotherapeutin;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="mannschaft"></param>
    public void AddMannschaft(Mannschaft mannschaft)
    {
        Mannschaften.Add(mannschaft);
    }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="physiotherapeutin"></param>
    public void AddPhysiotherapeutin(Physiotherapeutin physiotherapeutin)
    {
        Physiotherapeutin.Add(physiotherapeutin);
    }
}

