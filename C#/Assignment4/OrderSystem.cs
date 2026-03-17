using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    using System;
    using System.Collections.Generic;

    class Order
    {
        public int OrderId { get; set; }
        public double OrderAmount { get; set; }

        public Order(int id, double amount)
        {
            OrderId = id;
            OrderAmount = amount;
        }

        public virtual double CalculateShippingCost()
        {
            return 50;
        }
    }

    class StandardOrder : Order
    {
        public StandardOrder(int id, double amount) : base(id, amount) { }

        public override double CalculateShippingCost()
        {
            return 50;
        }
    }

    class ExpressOrder : Order
    {
        public ExpressOrder(int id, double amount) : base(id, amount) { }

        public override double CalculateShippingCost()
        {
            return 100;
        }
    }

    class InternationalOrder : Order
    {
        public InternationalOrder(int id, double amount) : base(id, amount) { }

        public override double CalculateShippingCost()
        {
            return 500;
        }
    }

    class OrderSystem
    {
        static void Main()
        {
            List<Order> orders = new List<Order>()
        {
            new StandardOrder(1, 2000),
            new ExpressOrder(2, 3000),
            new InternationalOrder(3, 5000)
        };

            foreach (Order o in orders)
            {
                Console.WriteLine(o.OrderId + " " + o.CalculateShippingCost());
            }
        }
    }
}
