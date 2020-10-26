using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    /// <summary>
    /// Summary description for AddressRepositoryTest
    /// </summary>
    [TestClass]
    public class AddressRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            AddressRepository addressRepository = new AddressRepository();
            Address expectedAddress = new Address(1);
            expectedAddress.AddressType = 1;
            expectedAddress.StreetLine1 = "Bag End";
            expectedAddress.StreetLine2 = "Bagshot row";
            expectedAddress.City = "Hobbiton";
            expectedAddress.State = "Shire";
            expectedAddress.Country = "Middle Earth";
            expectedAddress.PostalCode = "144";

            // Act
            Address actualAddress = addressRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expectedAddress.AddressType, actualAddress.AddressType);
            Assert.AreEqual(expectedAddress.StreetLine1, actualAddress.StreetLine1);
            Assert.AreEqual(expectedAddress.StreetLine2, actualAddress.StreetLine2);
            Assert.AreEqual(expectedAddress.City, actualAddress.City);
            Assert.AreEqual(expectedAddress.State, actualAddress.State);
            Assert.AreEqual(expectedAddress.Country, actualAddress.Country);
            Assert.AreEqual(expectedAddress.PostalCode, actualAddress.PostalCode);
        }
    }
}
