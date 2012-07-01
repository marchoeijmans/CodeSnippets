using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericExample
{
    public class Melding93Action
    {
        public int Identified { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public DateTime DateSend { get; set; }

        public override string ToString()
        {
            return (string.Format("Melding93Action: Identified={0}, Description={1}, Type={2}, DateSend={3}", Identified, Description, Type, DateSend));
        }
    }
}
