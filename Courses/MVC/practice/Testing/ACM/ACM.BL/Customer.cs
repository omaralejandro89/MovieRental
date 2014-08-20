using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer() : this(0)
        {
            
        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            //A list does not have a good default value because is null. Therefore it is better
            //inizialize it
            AddressList = new List<Address>(); //This will set the entire list into an empty list instead of null
        }

        //public Address WorkAddres { get; set; } //Or a list of addresses make more sense
        //public Address HomeAddress { get; set; }//

        public List<Address> AddressList { get; set; }

        public int CustomerType { get; set; }
        public static int InstanceCount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrEmpty(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public bool Validate()
        {
            var isvalid = true;

            if (string.IsNullOrWhiteSpace(LastName))
            {
                isvalid = false;
            }
            if (string.IsNullOrEmpty(EmailAddress))
            {
                isvalid = false;
            }
            return isvalid;
        }


    }
}
