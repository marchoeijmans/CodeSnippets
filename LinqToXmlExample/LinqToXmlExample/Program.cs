using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Xml;
using System;

using LinqToXmlExample.Helpers;

namespace LinqToXmlExample
{
    /// <summary>
    /// Inspiratie Bron: http://weblogs.asp.net/brijmohan/archive/2008/11/22/linq-to-xml-and-linq-to-objects-basic-sample.aspx
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //IEnumerable<XElement> elements = XmlDocumentCreator.CreateXDocumentSample().Element("BookParticipants").Elements("BookParticipant");

            //foreach (XElement element in elements)
            //{
            //    Console.WriteLine("Source element: {0} : value = {1}",
            //    element.Name, element.Value);

            //    Console.WriteLine("FirstName = {0}, LastName = {1}", element.Element("FirstName").Value, element.Element("LastName").Value);
            //}

            Console.WriteLine("Authors:");
            List<BookParticipant> authors = BookParticipants.GetBookAuthorsFromXML();
            foreach (BookParticipant author in authors)
            {
                Console.WriteLine(author.ToString());
            }

            Console.WriteLine();

            Console.WriteLine("Editors:");
            List<BookParticipant> editors = BookParticipants.GetBookEditorsFromXML();
            foreach (BookParticipant editor in editors)
            {
                Console.WriteLine(editor.ToString());
            }

            Console.ReadLine();
        }
    }
}
