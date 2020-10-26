using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            CustomerRepository customerRepository = new CustomerRepository();
            Customer expectedCustomer = new Customer(1);
            expectedCustomer.Email = "fbaggins@hobbiton.me";
            expectedCustomer.FirstName = "Frodo";
            expectedCustomer.LastName = "Baggins";

            // Act
            Customer actualCustomer = customerRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expectedCustomer.CustomerId, actualCustomer.CustomerId);
            Assert.AreEqual(expectedCustomer.Email, actualCustomer.Email);
            Assert.AreEqual(expectedCustomer.FirstName, actualCustomer.FirstName);
            Assert.AreEqual(expectedCustomer.LastName, actualCustomer.LastName);
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            // Arrange
            CustomerRepository customerRepository = new CustomerRepository();
            Customer expectedCustomer = new Customer(1);
            expectedCustomer.Email = "fbaggins@hobbiton.me";
            expectedCustomer.FirstName = "Frodo";
            expectedCustomer.LastName = "Baggins";
            expectedCustomer.AddressList = new List<Address>();

            Address address = new Address();
            address.AddressType = 1;
            address.StreetLine1 = "Bag End";
            address.StreetLine2 = "Bagshot row";
            address.City = "Hobbiton";
            address.State = "Shire";
            address.Country = "Middle Earth";
            address.PostalCode = "144";
            expectedCustomer.AddressList.Add(address);

            address = new Address();
            address.AddressType = 2;
            address.StreetLine1 = "Green Dragon";
            address.City = "Bywater";
            address.State = "Shire";
            address.Country = "Middle Earth";
            address.PostalCode = "146";
            expectedCustomer.AddressList.Add(address);

            // Act
            Customer actualCustomer = customerRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expectedCustomer.CustomerId, actualCustomer.CustomerId);
            Assert.AreEqual(expectedCustomer.Email, actualCustomer.Email);
            Assert.AreEqual(expectedCustomer.FirstName, actualCustomer.FirstName);
            Assert.AreEqual(expectedCustomer.LastName, actualCustomer.LastName);

            int count = expectedCustomer.AddressList.Count;
            for (int i = 0; i < count; i++)
            {
                Assert.AreEqual(expectedCustomer.AddressList[i].AddressType, actualCustomer.AddressList[i].AddressType);
                Assert.AreEqual(expectedCustomer.AddressList[i].StreetLine1, actualCustomer.AddressList[i].StreetLine1);
                Assert.AreEqual(expectedCustomer.AddressList[i].City, actualCustomer.AddressList[i].City);
                Assert.AreEqual(expectedCustomer.AddressList[i].State, actualCustomer.AddressList[i].State);
                Assert.AreEqual(expectedCustomer.AddressList[i].Country, actualCustomer.AddressList[i].Country);
                Assert.AreEqual(expectedCustomer.AddressList[i].PostalCode, actualCustomer.AddressList[i].PostalCode);
            }
        }

        [TestMethod]
        public void SaveTestValid()
        {
            // Arrange
            CustomerRepository customerRepository = new CustomerRepository();
            Customer updatedCustomer = new Customer(1);
            updatedCustomer.Email = "fbaggins@hobbiton.me";
            updatedCustomer.FirstName = "Frodo";
            updatedCustomer.LastName = "Baggins";
            updatedCustomer.HasChanges = true;

            // Act
            bool actualCustomer = customerRepository.Save(updatedCustomer);

            // Assert
            Assert.AreEqual(true, actualCustomer);
        }

        [TestMethod]
        public void SaveTestMissingEmail()
        {
            // Arrange
            CustomerRepository customerRepository = new CustomerRepository();
            Customer updatedCustomer = new Customer(1);
            updatedCustomer.Email = null;
            updatedCustomer.FirstName = "Frodo";
            updatedCustomer.LastName = "Baggins";
            updatedCustomer.HasChanges = true;

            // Act
            bool actualCustomer = customerRepository.Save(updatedCustomer);

            // Assert
            Assert.AreEqual(false, actualCustomer);
        }
    }
}
