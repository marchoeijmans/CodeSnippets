using System;
using AR = OptionalAndDefaulParameters.After;
using BR = OptionalAndDefaulParameters.Before; 

namespace OptionalAndDefaulParameters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BR.Email emailOldStyle = new BR.Email();
            emailOldStyle.SendMail("to address string 1 oldstyle", "email body");
            emailOldStyle.SendMail("to address string 2 oldstyle", "email body", true);
            emailOldStyle.SendMail("to address string 3 oldstyle", "email body", true, true);

            AR.Email emailNewStyle = new AR.Email();
            emailNewStyle.SendMail("to address string 1 new style", "email body");
            emailNewStyle.SendMail("to address string 2 new style", "email body", true);
            emailNewStyle.SendMail("to address string 3 new style", "email body", true, true);

            Console.ReadLine();
        }
    }
}
