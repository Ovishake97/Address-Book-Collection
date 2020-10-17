using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Xml;

namespace AddressBookProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book");
            Console.WriteLine("---------------------------");
            ChooseOptions();
            Console.ReadKey();
        }

        public static void SelectingOptions(int option) {
            AddressCheck address = new AddressCheck();
            switch (option) {
                case 1:
                    address.AddToAddressBook();
                    break;
                case 2:
                    address.EditDetails();
                    break;
                case 3:
                    address.DeleteDetails();
                    break;
                case 4:
                    address.ExistingAddressBook();
                    break;
                default:
                    Console.WriteLine("Enter valid options");
                    ChooseOptions();
                    break;
            }
        }
        public static void ChooseOptions() {
            Console.WriteLine("Choose from the following options");
            Console.WriteLine("\n1.Add to address book\n2.Edit details\n3.Delete details\n4.Display exisitng address books");
            int option = Convert.ToInt32(Console.ReadLine());
            SelectingOptions(option);
            Console.WriteLine("Do you wish to go back to the main menu? Enter Yes or No");
            string answer = Console.ReadLine();
            if (answer.ToLower().Equals("yes"))
            {
                ChooseOptions();
            }
            else {
                Console.WriteLine("Thank you");
            }
        }
    }
}
    

