using OOP8.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP8.Models
{
    class Store : IStore
    {
        private string name;
        private string adress;
        private string email;
        private int phoneNumber;

        public Store(string name, string adress, string email, int phoneNumber)
        {
            this.name = name;
            this.adress = adress;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }
        public string Name { get { return name; } }
        public string Adress { get { return adress; } }
        public string Email { get { return email; } }
        public int PhoneNumber { get { return phoneNumber; } }

        public void Claim()
        {
            Console.WriteLine("I have the best francize in the world.");
        }
        public override string ToString()
        {
            return $"Name: {Name}\nAdress: {Adress}\nEmail: {Email}\nPhone Number: {PhoneNumber}\n";
        }
    }
}
