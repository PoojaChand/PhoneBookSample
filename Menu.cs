using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PhoneBookSample
{
    class Menu
    {
        PhoneBook phonebook = new PhoneBook();
        public void MenuDetails()
        {
                //Menu menu=new Menu();
                Console.WriteLine("1: Add \n 2.Delete \n 3.Search \n 4.Exit");
        
        //public void Choice()
        
         List<Contact> contacts = new List<Contact>();
         int Choice = Int32.Parse(Console.ReadLine());
                if (Choice == 1)
                {

                Contact contact= phonebook.AddContact();
                //Contact contact = new Contact();
                // .AddContact();
                 
                }
              /*  else if (Choice == 2)
                {
                    phonebook.DeleteContact(contacts);
                }
                else if (Choice== 3)
                {
                    phonebook.ShowContact(contacts);
                }
                else
                {
                    Console.WriteLine("You have entered a wrong option.Please try again with different option.");
                }
                */

            }

    }
}
