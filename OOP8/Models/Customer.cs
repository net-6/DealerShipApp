using System;
using OOP8.Interface;
using System.Collections.Generic;
using System.Text;

namespace OOP8.Models
{
    public class Customer : Person,IPerson
    {
        public Customer(string firstName, string lastName, DateTime birthDate,Enumeration.Gender gender, string adress, string email, int phoneNumber) : base(firstName, lastName, birthDate, adress, email, phoneNumber,gender)
        {

        }
        public void See()
        {
            Console.WriteLine("I'm a person and I can see.");
        }
        public void Walk()
        {
            Console.WriteLine("I'm a person and I can walk.");
        }
        public void Drive()
        {
            Console.WriteLine("I'm a person and I can drive anything");
        }
        public override string ToString()
        {
            return $"First Name: {FirstName}\nLast Name: {LastName}\nAge: {Age}\nGender type: {Gender}\nAdress: {Adress}\nEmail: {Email}\nPhone Number: {PhoneNumber}\n";
        }

    }
}
