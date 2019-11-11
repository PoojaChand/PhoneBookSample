using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PhoneBookSample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();

            
            Boolean Flag = true;
            while(Flag)
            {
                Console.WriteLine("1 : Add ContactDetails");
                Console.WriteLine("2 : Delete ContactDetails");
                Console.WriteLine("3 : Display ContactDetails");
                Console.WriteLine("4 : Exit");
                int UserInput = Int32.Parse(Console.ReadLine());
                if (UserInput == 1)
                {
                    PhoneBook phonebook = new PhoneBook();

                    Contact contact= phonebook.AddContact();
                    contacts.Add(contact);
                    phonebook.ShowContact(contacts);

                }
                else if (UserInput == 2)
                {
                    PhoneBook phonebook = new PhoneBook();

                    phonebook.DeleteContact(contacts);
                    phonebook.ShowContact(contacts);

                }
                else if (UserInput == 3)
                {
                    PhoneBook phonebook  = new PhoneBook();
		    phonebook.ShowContact(contacts);
                }
                else if (UserInput == 4)
                {
                    Flag = false;
                }
                else
                {
                    Console.WriteLine("You have entered a wrong option.Please try again with different option.");
                   
                }

            }

          
        }
        }
    }

