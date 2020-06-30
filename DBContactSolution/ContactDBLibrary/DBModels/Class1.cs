using System;

namespace ContactDBLibrary
{
    public class Contact
    {
        public static int ID { get; set; }
        public string SSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Contact(string ssn, string firstName, string lastName)
        {
            SSN = ssn;
            FirstName = firstName;
            LastName = lastName;
            ID++;
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name}\n" +
                $"ID: {ID}\n" +
                $"SSN: {SSN}\n" +
                $"First Name: {FirstName}\n" +
                $"Last Name: {LastName}";
        }
    }

    public class Address
    {
        public static int AddressID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZIP { get; set; }

        public Address(string street, string city, string zIP)
        {
            Street = street;
            City = city;
            ZIP = zIP;
            AddressID++;
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name}\n" +
                $"AddressID: {AddressID}\n" +
                $"Street: {Street}\n" +
                $"City: {City}\n" +
                $"ZIP: {ZIP}";
        }
    }

    public class ContactInformation
    {
        public static int ID { get; set; }
        public string Info { get; set; }
        public int ContactID { get; set; }

        public ContactInformation(string info, int contactID)
        {
            Info = info;
            ContactID = contactID;
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name}\n" +
                $"ID: {ID}\n" +
                $"Info: {Info}\n" +
                $"ContactID: {ContactID}\n";
        }
    }

    public class ContactToAddress
    {
        public static int ID { get; set; }
        public int ContactID { get; set; }
        public int AddressID { get; set; }

        public ContactToAddress(int contactID, int addressID)
        {
            ContactID = contactID;
            AddressID = addressID;
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name}\n" +
                $"ID: {ID}\n" +
                $"ContactID: {ContactID}\n" +
                $"AddressID: {AddressID}\n";
        }
    }

    public static class SQLRepository
    {
        public static int CreateContact(string ssn, string firstName, string lastName)
        {
            //Contact newContact = new Contact(ssn, firstName, lastName);

            return 0;
        }
    }
}
//int CreateContact(string ssn, string firstName,
//string lastName) //Returns ID
//Contact ReadContact(int ID)
//List<Contact> ReadAllContacts()
//bool UpdateContact(int Id, string ssn,
//string firstName, string lastName)
//bool DeleteContact(int ID)


