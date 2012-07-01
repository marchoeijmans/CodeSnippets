using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LinqToXmlExample.Helpers
{
    public static class BookParticipants
    {
        // TODO: maak voorbeeld met namespace, haal deze op dmv root property + plaats namespace voor XML element bij ophalen
        public static List<BookParticipant> GetBookAuthorsFromXML()
        {
            XDocument xmlDoc = XmlDocumentCreator.CreateXDocumentSample();

            var bookParticipants = from participant in xmlDoc.Descendants("BookParticipant")
                                   where participant.Attribute("type").Value == "Author"

                            select new BookParticipant
                            {
                                FirstName = participant.Element("FirstName").Value,
                                LastName = participant.Element("LastName").Value,
                                ParticipantType = ParticipantTypes.Author
                            };
            return bookParticipants.ToList();
        }

        public static List<BookParticipant> GetBookEditorsFromXML()
        {
            XDocument xmlDoc = XmlDocumentCreator.CreateXDocumentSample();

            var bookParticipants = from participant in xmlDoc.Descendants("BookParticipant")
                                   where participant.Attribute("type").Value == "Editor"

                                   select new BookParticipant
                                   {
                                       FirstName = participant.Element("FirstName").Value,
                                       LastName = participant.Element("LastName").Value,
                                       ParticipantType = ParticipantTypes.Editor
                                   };
            return bookParticipants.ToList();
        }
    }
}
