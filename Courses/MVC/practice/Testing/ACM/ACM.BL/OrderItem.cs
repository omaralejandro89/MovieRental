using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {
            
        }

        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        public int OrderItemId { get; set; }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }

        public OrderItem Retrieves(int orderItemId)
        {
            //Code that saves the retrieves the current items
            return new OrderItem();
        }

        public bool Save()
        {
            //Code that saves the current items
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (OrderQuantity <= 0)
            {
                isValid = false;
            }
            if (OrderItemId <= 0)
            {
                isValid = false;
            }
            if (PurchasePrice == null)
            {
                isValid = false;
            }
            return isValid;
        }

    }
}
