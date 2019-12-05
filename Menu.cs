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
         List<Contact> contacts = new List<Contact>();
        public void  MenuDetails()
        { 
            int Choice = 0;
            while(true)
            {

              Console.WriteLine("Choose your choice");
                 
              Console.WriteLine(" 1: Add \n 2.Delete \n 3.Search \n 4.Exit");
        
   
        
        
          Choice = Int32.Parse(Console.ReadLine());
                switch(Choice)
                {
                    case 1:phonebook.AddContact();
                    break;
                    case 4:System.Environment.Exit(0);
                    break;

                }
              

            }

}
}
}