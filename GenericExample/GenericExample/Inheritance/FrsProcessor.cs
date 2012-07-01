using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericExample
{
    public class FrsProcessor: Processor<FrsEvent, Melding8Action, ProcessingInstructions, bool>
    {
        public FrsProcessor(FrsEvent eventPar, Melding8Action meldingPar, ProcessingInstructions instruction = ProcessingInstructions.ProcessFrsEvents)
            : base(eventPar, meldingPar, instruction)
        {
        }

        public override bool TryExecute()
        {
            base.Action.Id = base.Event.Id;
            base.Action.Soort = base.Event.Soort;
            base.Action.Type = "FRS@@@@";
            base.Action.DateReceived = base.Event.DateReceived;

            // do something
            return base.TryExecute();
        }
    }
}
