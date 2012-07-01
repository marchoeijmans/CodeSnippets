using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericExample
{
    public class Melding8Action
    {
        public int Id { get; set; }
        public string Soort { get; set; }
        public string Type { get; set; }
        public DateTime DateReceived { get; set; }

        public override string ToString()
        {
            return (string.Format("Melding8Action: Id={0}, Soort={1}, Type={2}, DateReceived={3}", Id,Soort, Type, DateReceived));
        }
    }
}
