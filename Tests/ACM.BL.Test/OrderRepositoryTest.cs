using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    /// <summary>
    /// Summary description for OrderRepositoryTest
    /// </summary>
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            OrderRepository orderRepository = new OrderRepository();
            Order expectedOrder = new Order(10);
            expectedOrder.OrderDate = new DateTimeOffset(DateTime.Now.Year, 10, 19, 16, 30, 30, new TimeSpan(7, 0, 0));

            // Act
            Order actualOrder = orderRepository.Retrieve(10);

            // Assert
            Assert.AreEqual(expectedOrder.OrderDate, actualOrder.OrderDate);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            // Arrange
            OrderRepository orderRepository = new OrderRepository();
            Order updatedOrder = new Order(10);
            updatedOrder.OrderDate = new DateTimeOffset(DateTime.Now.Year, 10, 19, 16, 30, 30, new TimeSpan(7, 0, 0));
            updatedOrder.HasChanges = true;

            // Act
            bool actualOrder = orderRepository.Save(updatedOrder);

            // Assert
            Assert.AreEqual(true, actualOrder);
        }

        [TestMethod]
        public void SaveTestMissingOrderDate()
        {
            // Arrange
            OrderRepository orderRepository = new OrderRepository();
            Order updatedOrder = new Order(10);
            updatedOrder.OrderDate = null;
            updatedOrder.HasChanges = true;

            // Act
            bool actualOrder = orderRepository.Save(updatedOrder);

            // Assert
            Assert.AreEqual(false, actualOrder);
        }
    }
}
