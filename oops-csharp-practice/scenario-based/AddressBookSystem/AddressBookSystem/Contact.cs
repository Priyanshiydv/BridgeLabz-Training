using System;

namespace AddressBookSystem
{
    class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
   


        public void Display()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            Console.WriteLine("Address: " + Address + ", " + City + ", " + State + " - " + Zip);
            Console.WriteLine("Phone: " + PhoneNumber);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("----------------------------");
        }
        // UC7: Override Equals for duplicate check
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Contact))
                return false;

            Contact other = (Contact)obj;

            return FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase)
                && LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return (FirstName + LastName).ToLower().GetHashCode();
        }
    }
}

