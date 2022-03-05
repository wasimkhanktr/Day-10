using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsDetails
{
    public class Contacts
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public double phoneNo { get; set; }
        public string eMail { get; set; }

        public static Contacts AddContactFromConsole()
        {
            Contacts C1 = new Contacts();
            Console.Write("Enter first name: ");
            C1.firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            C1.lastName = Console.ReadLine();
            Console.Write("Enter address details: ");
            C1.address = Console.ReadLine();
            Console.Write("Enter city name: ");
            C1.city = Console.ReadLine();
            Console.Write("Enter state name: ");
            C1.state = Console.ReadLine();
            Console.Write("Enter zip Code: ");
            C1.zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter phone Number: ");
            C1.phoneNo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ebter your mail Id: ");
            C1.eMail = Console.ReadLine();
            Console.WriteLine($"Details of {C1.firstName} added successfully");
            return C1;
        }

    }
}