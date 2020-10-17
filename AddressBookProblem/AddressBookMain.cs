using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProblem
{
   public class AddressBookMain
    {
        public String firstName;
        public String lastName;
        public String address;
        public String state;
        public int zip;
        public double phoneNo;
        public string emailId;


        public AddressBookMain(string firstName, string lastName, string address, string state, int zip, double phoneNo, string emailId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.state = state;
            this.zip = zip;
            this.phoneNo = phoneNo;
            this.emailId = emailId;
        }
    }
}
