using System;
using System.Runtime.InteropServices;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bildo";
            customer.LastName = "Chacin";

            string expected = "Chacin, Bildo";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void staticTest()
        {
            //Arrange
            var c1 = new Customer();
            c1.FirstName = "Blido";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            //Act


            //Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateTest()
        {
            //Arrange
            var customer = new Customer();
            customer.LastName = "Chacin";
            customer.EmailAddress = "omar@laboremus.no";

            var expected = true;


            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //Arrange
            var customer = new Customer();
            customer.EmailAddress = "omar@laboremus.no";

            var expected = false;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
