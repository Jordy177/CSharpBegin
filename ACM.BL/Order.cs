using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class Order
    {
        public int OrderId {get; private set;}
        public DateTimeOffset? OrderDate {get; set;}


        public Order()
        {

        }  

        public Order(int orderId)
        {
            OrderId = orderId;
        }          

        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}