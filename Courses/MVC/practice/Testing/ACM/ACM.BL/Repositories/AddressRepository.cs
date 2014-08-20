using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Repositories
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.StreetLine1 = "Bag end";
                address.StreetLine2 = "Karl Johans";
                address.City = "Oslo";
                address.Country = "Norway";
                address.State = "Oslo State";
                address.PostalCode = "551453";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            //Code that retrieves the defined addresses for the customer

            //Temporary hard coded values to return
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag end",
                StreetLine2 = "Karl Johans",
                City = "Oslo",
                Country = "Norway",
                State = "Oslo State",
                PostalCode = "551453"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 1,
                StreetLine1 = "Bag start",
                StreetLine2 = "Av Barcelona",
                City = "Ålesund",
                Country = "Norway",
                State = "Ålesund State",
                PostalCode = "12345"
            };
            addressList.Add(address);
            return addressList;
        }
        
        

        public bool Save(Address address)
        {
            // Code that saves the defined address
            return true;
        }
    }
}
