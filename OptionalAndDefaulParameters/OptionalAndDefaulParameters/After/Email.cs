using System;

namespace OptionalAndDefaulParameters.After
{
    public class Email
    {
        public Email() 
        { 
        }

        // example of use of optional parameters with default values
        // optional parameters must be places at the end of the signature
        public void SendMail(string toAddress, string bodyText, bool sendCCToAdministrator = true, bool isBodyHtml = false)
        {
            Console.WriteLine(string.Format("Send email toAddress: {0}, bodyText: {1}, sendCCToAdministrator: {2}, isBodyHtml: {3}", toAddress, bodyText, sendCCToAdministrator, isBodyHtml));
        }
    }
}
