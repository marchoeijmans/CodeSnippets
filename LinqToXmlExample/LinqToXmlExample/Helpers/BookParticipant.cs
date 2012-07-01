using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqToXmlExample.Helpers
{
    public enum ParticipantTypes
    {
        Author = 0,
        Editor
    }
    public class BookParticipant
    {
        public string FirstName;
        public string LastName;
        public ParticipantTypes ParticipantType;

        public override string ToString()
        {
            return string.Format("FirstName = {0}, LastName={1}, Type={2}", FirstName, LastName, ParticipantType);
        }
    }
}
