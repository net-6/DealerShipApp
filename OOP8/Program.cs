using OOP8.Models;
using System;

namespace OOP8
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store1 = new Store("Ford", "Municipiul Iasi,Strada Florilor,nr2", "forddiasi@yahoo.ro", 0739358861);
            Producer producer1 = new Producer("AUDI MOTORS", "Bucuresti,Strada Lalelelor,nr.15", "audiromania@yahoo.com", 0234563344);
            Car car1 = new Car("AUDI", Enumeration.CarType.SportBack, "A3", 40000);
            Car car2 = new Car("AUDI", Enumeration.CarType.SUV, "RSQ3", 100000);
            Customer customer1 = new Customer("Tenu", "Vlad",new DateTime(1996,01,18),Enumeration.Gender.Male, "Iasi,Bulevardul Independentei,nr.2", "tenuvlad@yahoo.com", 0735465634);
            Order order = new Order(new DateTime(2020,02,15), 30);
            order.Cars.Add(car1);
            order.Cars.Add(car2);
            Console.WriteLine($"Store Info \n{store1.ToString()}\nProducer Info \n{producer1.ToString()}\nCar Info \n{car1.ToString()}\n{car2.ToString()}\nCustomer Info\n{customer1.ToString()}\nOrder Info \n{order.ToString()}");


        }
    }
}
