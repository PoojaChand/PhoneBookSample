using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookSample
{
    class PhoneBook
    {
        public Contact AddContact()
        {
            Contact Contact = new Contact();

            Console.WriteLine("Enter firstName : ");
            Contact.firstName = Console.ReadLine();
            Console.WriteLine("Enter lastName : ");
            Contact.lastName = Console.ReadLine();
            Console.WriteLine("Enter phoneNumber : ");
            Contact.phoneNumber =Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Enter emailId : ");
            Contact.emailId = Console.ReadLine();
            Console.Write("Contact added successfully.");
            return Contact;
           
        }
        public void DeleteContact(List<Contact> contacts)
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
