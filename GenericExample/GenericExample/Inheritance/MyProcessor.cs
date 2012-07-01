using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericExample
{
    public class MyProcessor : Processor<FrsEvent, Melding8Action, string, string>
    {
        public MyProcessor(FrsEvent eventPar, Melding8Action meldingPar, string instruction=null)
            : base(eventPar, meldingPar, instruction)
        {
        }

        public override string TryExecute()
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
