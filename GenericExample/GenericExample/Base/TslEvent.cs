using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericExample
{
    public class TslEvent
    {
        public TslEvent(int id, string type, DateTime dateReceived)
        {
            this.Id = id;
            this.Type = type;
            this.DateReceived = dateReceived;
        }
        
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime DateReceived { get; set; }
    }
}
