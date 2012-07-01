using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericListExistExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listToCheck = new List<string>()
	                                    {
	                                        "carrot",
	                                        "fox",
	                                        "explorer"
	                                    };
            string valueToCheckIfExistInList = "appel";

            bool result = !(listToCheck.Exists(delegate(string processDefinitionNameInList)
             { return listToCheck == valueToCheckIfExistInList; }));

            Console.WriteLine(result);
            Console.ReadLine();
            
            
        }

        }
    }
}
