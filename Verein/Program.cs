namespace Verein
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Praesident praesident = new Praesident("Oskar Buhmann");
            Verein verein = new Verein("FC Sonnenanbeter");
            Mannschaft mannschaft = new Mannschaft("Erste Mannschaft");
            Torwart torwart = new Torwart("Jan Sommer");
            Feldspieler feldspieler = new Feldspieler("Fabian Frei");

            mannschaft.AddTorwart(torwart);
            mannschaft.AddFeldspieler(feldspieler);

            Physiotherapeutin physiotherapeutin = new Physiotherapeutin("Maria");

            verein.AddMannschaft(mannschaft);
            verein.AddPhysiotherapeutin(physiotherapeutin);

         
            praesident.VertragUnterzeichnen();
            torwart.BallHalten();
            feldspieler.Schiessen();
            physiotherapeutin.Massieren();
        }
    }
}
