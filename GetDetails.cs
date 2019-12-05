using System;  
  
namespace PhoneBookSample
{
    class GetDetails : IHandler
      {
          public Contact GetData(Contact contact)
          {   
              Console.WriteLine("Enter firstName : ");
              contact.firstName = Console.ReadLine();
              Console.WriteLine("Enter lastName : ");
              contact.lastName = Console.ReadLine();
              Console.WriteLine("Enter phoneNumber : ");
              contact.phoneNumber =Convert.ToDouble( Console.ReadLine());
              Console.WriteLine("Enter emailId : ");
              contact.emailId = Console.ReadLine();
              Console.Write("Contact added successfully.");
              return contact;
          }

        }
  }
