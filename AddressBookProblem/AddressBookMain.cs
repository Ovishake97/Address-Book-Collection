using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProblem
{
   public class AddressBookMain
    {
        public String firstName { get; set; }
        public String lastName{ get; set; }
        public String address{ get; set; }
        public String state{ get; set; }
        public int zip { get; set; }
        public double phoneNo { get; set; }
        public string emailId { get; set; }


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
