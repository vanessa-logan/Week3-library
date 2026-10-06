using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Member
    {
        // Private backing fields
        private int memberId;
        private string name;
        private string address;
        private string phone; // Changed to string to keep the leading zeros

        // Public properties
        public int MemberId
        {
            get { return memberId; }
            private set
            {
                if (value > 0)
                {
                    memberId = value;
                }
                else
                {
                    Console.WriteLine("Error: Member ID must be greater than zero.");
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                // Ensure name does not contain any numbers
                if (!value.Any(char.IsDigit) && value != "")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Error: Member name cannot be blank or contain numbers.");
                }
            }
        }

        public string Address
        {
            get { return address; } // get method
            set { address = value; } // set method
        }

        public string Phone
        {
            get { return phone; } // get method
            set { phone = value; } // set method
        }

        // Constructor for new member
        public Member (int memberId, string name, string address, string phone)
        {
            this.MemberId = memberId; // Assigns the camelCase parameter to the PascalCase property
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        // Method to display information about a member
        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberId}");
            Console.WriteLine($"Member Name: {Name}");
            Console.WriteLine($"Member Address: {Address}");
            Console.WriteLine($"Member Phone Number: {Phone}");
            Console.WriteLine();
        }

    }
}
