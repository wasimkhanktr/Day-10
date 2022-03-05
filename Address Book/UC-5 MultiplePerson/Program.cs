using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsDetails;
using Address;

namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address Book Program");
            //VARIABLES
            string choiceToAddContacts = string.Empty;
            string nameofEditOrDeleteContact = string.Empty;
            string choiceToEditOrDelete = string.Empty;

            Address_Book book = new Address_Book();
            //For Adding Contact Details
            do
            {
                Contacts c = Contacts.AddContactFromConsole();
                book.AddContacts(c);
                Console.WriteLine("Do u want to add Contacts: - Y or N");
                choiceToAddContacts = Console.ReadLine().ToUpper();
            } while (choiceToAddContacts != "N");

            //For Editing or Deleting Contacts
            Console.WriteLine("Please enter name of the person for whom u want to edit or delete details: ");
            nameofEditOrDeleteContact = Console.ReadLine();
            Console.WriteLine("Please select E or D to edit or delete the contacts respectively on list ");
            choiceToEditOrDelete = Console.ReadLine().ToUpper();
            switch (choiceToEditOrDelete)
            {
                case "E":
                    book.editContacts(nameofEditOrDeleteContact);
                    break;
                case "D":
                    book.deleteContacts(nameofEditOrDeleteContact);
                    break;
                default:
                    Console.WriteLine("Invalid Selection ! Enter E or D");
                    break;
            }
            //Verifying Details are edited or deleted.
            book.getContacts();
        }
    }
}