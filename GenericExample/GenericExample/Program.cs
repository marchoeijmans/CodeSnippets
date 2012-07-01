using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // same as new Melding8Action(), can be used as some kind of factory pattern.
            Melding8Action melding8 = FrsProcessor.CreateMeldingInstance<Melding8Action>(); 
            Melding93Action melding93 = TslProcessor.CreateMeldingInstance<Melding93Action>();

            FrsEvent frsEvent = new FrsEvent(801101, "Soort FRS", DateTime.Now);
            TslEvent tslEvent = new TslEvent(123456789, "TSL", DateTime.Now.AddDays(2.00));

            FrsProcessor frsProcessor = new FrsProcessor(frsEvent, melding8);
            frsProcessor.Instruction = ProcessingInstructions.ProcessAll;
            Console.WriteLine(frsProcessor.GetType());
            Console.WriteLine(frsProcessor.TryExecute());

            Console.WriteLine("======================================================");

            TslProcessor tslProcessor = new TslProcessor(tslEvent, melding93);
            tslProcessor.Instruction = false;
            Console.WriteLine(tslProcessor.GetType());
            Console.WriteLine(tslProcessor.TryExecute());
            Console.WriteLine("======================================================");

            MyProcessor myProcessor = new MyProcessor(frsEvent, melding8, "UseDefault");
            Console.WriteLine(myProcessor.GetType());
            Console.WriteLine(myProcessor.TryExecute());
            Console.WriteLine("======================================================");

            Console.ReadLine();
        }
    }
}
