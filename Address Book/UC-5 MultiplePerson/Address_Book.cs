using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsDetails;

namespace Address
{
    internal class Address_Book
    {
        List<Contacts> listOfContacts = new List<Contacts>();
        public void AddContacts(Contacts c)
        {
            listOfContacts.Add(c);
        }
        //For editing the contact of the person
        public void editContacts(string firstname)
        {
            Contacts editedContact = null;
            foreach (var existingContact in listOfContacts)
            {
                if (existingContact.firstName == firstname)
                {
                    editedContact = existingContact;
                    Console.Write("Please enter new email id: ");
                    editedContact.eMail = Console.ReadLine();
                    Console.Write("Please enter new Phone Number: ");
                    editedContact.phoneNo = Convert.ToDouble(Console.ReadLine());
                }
            }
        }

        //For deleting the contact of the person
        public void deleteContacts(string firstName)
        {
            Contacts Contact = null;

            foreach (var deletingContact in listOfContacts)
            {
                if (deletingContact.firstName == firstName)
                {
                    Contact = deletingContact;
                }
            }

            if (Contact != null)
            {
                listOfContacts.Remove(Contact);
            }
        }
        public void getContacts()
        {
            foreach (var v in listOfContacts)
            {
                Console.WriteLine($"Full Name of the contact is {v.firstName + " " + v.lastName}\nAddress of Contact is {v.address + "," + v.city + "," + v.state + ",zip:" + v.zip}.\nMail Id is {v.eMail}\nPhone Number is {v.phoneNo}");
            }
        }
    }
}