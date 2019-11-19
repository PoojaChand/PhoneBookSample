using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookSample
{
    class PhoneBook
    {
        List<Contact> contacts = new List<Contact>();
        GetDetails getDetails = new GetDetails();
        public Contact AddContact()
        {
            Contact contact = new Contact();
            getDetails.GetData();
            contacts.Add(contact);
            return contact;
            
           
        }
        /*   public void DeleteContact(List<Contact> contacts)
  {
      Console.Write("Enter phone number you want to delete:");
      double phonenumber =Convert.ToDouble(Console.ReadLine());
      contacts.RemoveAll(mobileNumber => mobileNumber.phoneNumber == phonenumber);
      Console.Write("Contact deleted successfully");

  }
  public void ShowContact(List<Contact> contacts)
  {
      foreach (var person in contacts)
      {
          Console.WriteLine("Name : " + person.firstName + " " + person.lastName + ",PhoneNumber :" + person.phoneNumber + ", Email Id:" + person.emailId);
      }


  }*/
    }
}
