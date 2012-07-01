using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericExample
{
    public class FrsEvent
    {
        public FrsEvent(int id, string soort, DateTime dateReceived)
        {
            this.Id = id;
            this.Soort = soort;
            this.DateReceived = dateReceived;
        }

        public int Id { get; set; }
        public string Soort { get; set; }
        public DateTime DateReceived { get; set; }
    }
}
