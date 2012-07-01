using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericExample
{
    public class TslProcessor: Processor<TslEvent, Melding93Action, bool, string>
    {
        public TslProcessor(TslEvent eventPar, Melding93Action meldingPar, bool instruction=true) 
            : base(eventPar, meldingPar, instruction)
        {
        }
        
        public override string TryExecute()
        {
            base.Action.Identified = base.Event.Id;
            base.Action.Description = "Description TSL";
            base.Action.Type = base.Event.Type;
            base.Action.DateSend = base.Event.DateReceived;
            base.Result = "Succeeded";

            // do something
            return base.TryExecute();
        }
    }
}
