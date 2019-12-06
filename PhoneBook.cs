using System;
using System.Collections.Generic;

namespace PhoneBookSample
{
    class PhoneBook
    {
        List<Contact> contacts = new List<Contact>();
        GetDetails getDetails = new GetDetails();
        Contact contact = new Contact();
        FileHandler fileHandler = new FileHandler();
        public void AddContact()
        {
           getDetails.GetData(contact);
           contacts.Add(contact);
           fileHandler.Details(contacts);
        }
        public void DeleteContact()
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

        }
    }
}
