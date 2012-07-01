using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace LinqToXmlExample
{
    /// <summary>
    /// Creation of an instance of XML sample document: 
    /// <BookParticipants>
    ///    <BookParticipant type="Author">
    ///        <FirstName>Joe</FirstName>
    ///        <LastName>Rattz</LastName>
    ///    </BookParticipant>
    ///    <BookParticipant type="Editor">
    ///        <FirstName>Ewan</FirstName>
    ///        <LastName>Buckingham</LastName>
    ///    </BookParticipant>
    ///</BookParticipants>
    /// </summary>
    public static class XmlDocumentCreator
    {
        public static XmlDocument CreateXmlDocumentSample()
        {
            XmlElement xmlBookParticipant;
            XmlAttribute xmlParticipantType;
            XmlElement xmlFirstName;
            XmlElement xmlLastName;

            XmlDocument xmlDoc = new XmlDocument();

            XmlElement xmlBookParticipants = xmlDoc.CreateElement("BookParticipants");
            xmlDoc.AppendChild(xmlBookParticipants);

            xmlBookParticipant = xmlDoc.CreateElement("BookParticipant");
            xmlParticipantType = xmlDoc.CreateAttribute("type");
            xmlParticipantType.InnerText = "Author";
            xmlBookParticipant.Attributes.Append(xmlParticipantType);
            xmlFirstName = xmlDoc.CreateElement("FirstName");
            xmlFirstName.InnerText = "Joe";
            xmlBookParticipant.AppendChild(xmlFirstName);
            xmlLastName = xmlDoc.CreateElement("LastName");
            xmlLastName.InnerText = "Rattz";
            xmlBookParticipant.AppendChild(xmlLastName);

            xmlBookParticipants.AppendChild(xmlBookParticipant);

            xmlBookParticipant = xmlDoc.CreateElement("BookParticipant");
            xmlParticipantType = xmlDoc.CreateAttribute("type");
            xmlParticipantType.InnerText = "Editor";
            xmlBookParticipant.Attributes.Append(xmlParticipantType);
            xmlFirstName = xmlDoc.CreateElement("FirstName");
            xmlFirstName.InnerText = "Ewan";
            xmlBookParticipant.AppendChild(xmlFirstName);
            xmlLastName = xmlDoc.CreateElement("LastName");
            xmlLastName.InnerText = "Buckingham";
            xmlBookParticipant.AppendChild(xmlLastName);
            xmlBookParticipants.AppendChild(xmlBookParticipant);

            return xmlDoc;
        }

        public static XElement CreateXElementSampleDoc()
        {
            XElement xBookParticipants =
            new XElement("BookParticipants",
            new XElement("BookParticipant",
            new XAttribute("type", "Author"),
            new XElement("FirstName", "Joe"),
            new XElement("LastName", "Rattz")),
            new XElement("BookParticipant",
            new XAttribute("type", "Editor"),
            new XElement("FirstName", "Ewan"),
            new XElement("LastName", "Buckingham")));

            return xBookParticipants;
        }

        public static XDocument CreateXDocumentSample()
        {
            XDocument xDocument = new XDocument(
            new XElement("BookParticipants",
            new XElement("BookParticipant",
            new XAttribute("type", "Author"),
            new XElement("FirstName", "Joe"),
            new XElement("LastName", "Rattz")),

            new XElement("BookParticipant",
            new XAttribute("type", "Author"),
            new XElement("FirstName", "Marc"),
            new XElement("LastName", "Hoeijmans")),

            
            new XElement("BookParticipant",
            new XAttribute("type", "Editor"),
            new XElement("FirstName", "Ewan"),
            new XElement("LastName", "Buckingham")),
            
            new XElement("BookParticipant",
            new XAttribute("type", "Editor"),
            new XElement("FirstName", "Peter"),
            new XElement("LastName", "Veen van der"))));

            return xDocument;
        }
    }
}
