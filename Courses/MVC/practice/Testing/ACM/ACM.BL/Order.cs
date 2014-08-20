using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {
            
        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }

        public DateTimeOffset?OrderDate { get; set; }
        public int OrderId { get; set; }
        public List<OrderItem> orderItems { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (OrderId == null)
            {
                isValid = false;
            }

            return isValid;
        }

    }
}
