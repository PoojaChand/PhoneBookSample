using System;
using System.IO;
using System.Collections.Generic;

namespace PhoneBookSample
{
    class FileHandler
    {

        public void Details(List<Contact> contacts)
        {
            string path = @"D:\program\ContactDetails.txt";
            if(!File.Exists(path))
            {
                Console.WriteLine("FileExists");
            }
             using (var writeToFile = new StreamWriter(path, true))
            {
                foreach (var item in contacts)
                {
                    string contactInformation = string.Concat("FirstName: ", item.firstName, Environment.NewLine, "LastName: ", item.lastName, Environment.NewLine,  "PhoneNumber: ", item.phoneNumber, Environment.NewLine, "EmailId: ", item.emailId);
                    writeToFile.WriteLine(contactInformation);
                     writeToFile.WriteLine("###########");
                }
            }
        }

    }
}