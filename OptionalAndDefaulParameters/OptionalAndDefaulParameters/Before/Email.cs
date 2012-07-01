using System;

namespace OptionalAndDefaulParameters.Before
{
    public class Email
    {
        public Email() 
        { 
        }

        public void SendMail(string toAddress, string bodyText)
        {
            this.SendMail(toAddress, bodyText, true);
        }

        public void SendMail(string toAddress, string bodyText, bool sendCCToAdministrator)
        {
            this.SendMail(toAddress, bodyText, sendCCToAdministrator, false);
        }

        public void SendMail(string toAddress, string bodyText, bool sendCCToAdministrator, bool isBodyHtml)
        {  
            Console.WriteLine(string.Format("Send email toAddress: {0}, bodyText: {1}, sendCCToAdministrator: {2}, isBodyHtml: {3}", toAddress, bodyText, sendCCToAdministrator, isBodyHtml));
        }
    }
}
