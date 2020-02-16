using System;
using System.Collections.Generic;
using System.Text;

namespace OOP8.Models
{
    public abstract class Person
    {
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string adress;
        private string email;
        private int phoneNumber;
        private Enumeration.Gender gender;

        public Person(string firstName, string lastName,DateTime birthDate,string adress,string email,int phoneNumber,Enumeration.Gender gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.adress = adress;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.gender = gender;
        }
        public string FirstName { get { return firstName; } }
        public Enumeration.Gender Gender { get { return gender; } }
        public string LastName { get { return lastName; } }
        public int Age { get { return (DateTime.Now - birthDate).Days / 365; } }
        public string Adress { get { return adress; } }
        public string Email { get { return email; } }
        public int PhoneNumber { get { return phoneNumber; } }
    }
}
