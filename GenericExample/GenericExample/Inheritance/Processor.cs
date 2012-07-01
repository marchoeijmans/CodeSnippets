using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericExample
{
    // generic class
    // class constaints
    public class Processor<TEvent, TMeldingAction, TProcessingInstruction, TProcessingResult> : IProcessor<TProcessingResult>  where TEvent : class where TMeldingAction : class
    {
        // constructor with generics
        public Processor(TEvent eventPar, TMeldingAction actionPar, TProcessingInstruction instruction)
        {
            this.Event = eventPar;
            this.Action = actionPar;
            this.Instruction = instruction;
        }
        
        // generic private fields
        protected TEvent Event { get; set; }
        protected TMeldingAction  Action { get; set; }
        protected TProcessingResult Result { get; set; }

        // generic public property
        public TProcessingInstruction Instruction { get; set; }

        // method that returns a generic (Tresult)
        // Try pattern is used: when execution fails, no exception is thrown
        // the processing result is returned indicating the result
        public virtual TProcessingResult TryExecute()
        {
            try
            {
                // using the default value of a generic parameter
                // TProcessingInstruction does not have a constraint and can be null
                // alway check before using the default value
                if (this.Instruction != null)
                {
                    Console.WriteLine(default(TProcessingInstruction));
                    Console.WriteLine(Action.ToString() + " instruction = " + Instruction.ToString());
                    // do something and deterime the result
                }
            }
            catch (Exception ex)
            {
                // log the execption
                Console.WriteLine(ex.Message);
            }
            return Result;
        }

        // method with create new instance constraint
        public static TAction CreateMeldingInstance<TAction>() where TAction : new()
        {
            return new TAction();
        }
    }
}
