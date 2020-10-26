using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";
            string exprectedName = "Baggins, Bilbo";

            // Act
            string actualName = customer.FullName;

            // Assert
            Assert.AreEqual(exprectedName, actualName);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            Customer customer = new Customer();
            customer.LastName = "Baggins";
            string exprectedName = "Baggins";

            // Act
            string actualName = customer.FullName;

            // Assert
            Assert.AreEqual(exprectedName, actualName);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            string exprectedName = "Bilbo";

            // Act
            string actualName = customer.FullName;

            // Assert
            Assert.AreEqual(exprectedName, actualName);
        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange
            Customer c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount++;

            Customer c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount++;

            Customer c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount++;

            // Act

            // Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            Customer customer = new Customer();
            customer.LastName = "Baggins";
            customer.Email = "fbaggins@hobbiton.me";

            bool expected = true;

            // Act
            bool actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            // Arrange
            Customer customer = new Customer();
            customer.Email = "fbaggins@hobbiton.me";

            bool expected = false;

            // Act
            bool actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}