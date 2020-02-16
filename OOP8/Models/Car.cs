using OOP8.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP8.Models
{
    public class Car : ICar
    {
        private string name;
        private Enumeration.CarType carType;
        private string carModel;
        private int price;

        public Car(string name,Enumeration.CarType carType,string carModel,int price)
        {
            this.name = name;
            this.carType = carType;
            this.carModel = carModel;
            this.price = price;
        }
        public string Name { get { return name; } }
        public Enumeration.CarType CarType { get { return carType; } }
        public string CarModel { get { return carModel; } }
        public int Price { get { return price; } }

        public void Drive()
        {
            Console.WriteLine("I'm a car and I can move");
        }
        public void Rotate()
        {
            Console.WriteLine("I'm a car and I can rotate the wheels.");
        }
        public void Transport()
        {
            Console.WriteLine("I'm a car and I can transport persons.");
        }
        public override string ToString()
        {
            return $"Name: {Name}\nCar Type: {CarType}\nCar Model: {CarModel}\nPrice: {Price}\n";
        }
    }
}
