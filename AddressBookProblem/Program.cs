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

        ///Defining a method to facilitate choosing an option for the user
        public static void SelectingOptions(int option) {
            switch (option) {
                case 1:
                    AddressCheck.AddToAddressBook();
                    break;
                case 2:
                   AddressCheck.EditDetails();
                    break;
                case 3:
                   AddressCheck.DeleteDetails();
                    break;
                case 4:
                    AddressCheck.GetAddressBook();
                    break;
                case 5:
                    AddressCheck.SearchByCity();
                    break;
                case 6:
                    AddressCheck.SearchByState();
                    break;
                case 7:
                    AddressCheck.CountPeopleFromCityAndState();
                    break;
                default:
                    Console.WriteLine("Enter valid options");
                    ChooseOptions();
                    break;
            }
        }
        ///  Displaying the list of options available for the user
        public static void ChooseOptions() {
            Console.WriteLine("Choose from the following options");
            Console.WriteLine("\n1.Add to address book\n2.Edit details\n3.Delete details\n4.Display exisitng address books\n5.Search people in a city\n6.Search people in a state\n7.Count the no. people in a state or in a city");
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
    

