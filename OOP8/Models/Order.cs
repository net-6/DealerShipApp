using OOP8.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP8.Models
{
    class Order : IOrder
    {
        public Car info { get; set; }
        private int identifier;
        private DateTime datePutOrder;
        private int timeOrder;
        public List<Car> Cars { get; set; } = new List<Car>();
        public List<Producer> Producers { get; set; } = new List<Producer>();
        public int Identifier { get { return identifier; } }

        public int TimeOrder { get { return timeOrder; } }
        public Order(DateTime datePutOrder,int timeOrder)
        {
            var random = new Random();
            this.identifier = random.Next();
            this.datePutOrder = datePutOrder;
            this.timeOrder = timeOrder;
        }

        public decimal TotalPrice()
        {
            List<decimal> carsPrice = new List<decimal>();
            foreach (var item in Cars)
            {
                carsPrice.Add(item.Price);
            }
            decimal sum = 0;
            foreach (var totalPrice in carsPrice)
            {
                sum = totalPrice + sum;
            }
            return sum;
        }
        public void OrderStatus()
        {
            Console.WriteLine("The order has been sent succefully.");
        }
        public override string ToString()
        {
            return $"Order Number: {Identifier}\nDate of Order: {datePutOrder}\nDelivery time: {TimeOrder} Days\nTotal price: {TotalPrice()}";
        }
    }
}
