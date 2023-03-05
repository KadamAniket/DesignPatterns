using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Models
{
    public class Order
    {
        public Guid OrderId { get;}

        public int Amount { get; }

        public Order(Guid id,int amount)
        {
            this.OrderId = id;
            this.Amount = amount;
        }

    }
}
