using DiamontProblem.Entities.Interfaces;

namespace DiamontProblem.Entities
{
    internal class Printer : Device, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }

    }
}
