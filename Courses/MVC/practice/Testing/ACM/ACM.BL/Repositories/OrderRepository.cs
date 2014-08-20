using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Repositories
{
    public class OrderRepository
    {
        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
           OrderDisplay orderDisplay = new OrderDisplay();

            //Code that retrieves the defined order fields

            //Temporary Hard-Coded data
            if (orderId == 10)
            {
                orderDisplay.FirstName = "Omar";
                orderDisplay.LastName = "Chacin";
                orderDisplay.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan());
                orderDisplay.ShippingAdd = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag end",
                    StreetLine2 = "Karl Johans",
                    City = "Oslo",
                    Country = "Norway",
                    State = "Oslo State",
                    PostalCode = "551453"
                };
            }


            orderDisplay.orderDisplayItemList = new List<OrderDisplayItem>();

            //Code that retrieves the order items

            //Temporary Hard-coded data

            if (orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Sunflowers",
                    PurchasePrime =  15.95M,
                    OrderQuantity = 2
                };

                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Rake",
                    PurchasePrime = 6M,
                    OrderQuantity = 1
                };
            }

            return orderDisplay;
        }

        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            //Code that retrieves the defined order
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset();
            }

            return order;
        }

        public bool Save()
        {
            //Code that saves the defined value
            return true;
        }
    }
}
