using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            ProductRepository productRepository = new ProductRepository();
            Product expectedProduct = new Product(1);
            expectedProduct.ProductName = "Sunflowers";
            expectedProduct.ProductDescription = "Assorted Size Set of 7 Bright Yellow Mini Sunflowers";
            expectedProduct.CurrentPrice = 19.99M;

            // Act
            Product actualProduct = productRepository.Retrieve(2);

            // Assert
            Assert.AreEqual(expectedProduct.ProductName, actualProduct.ProductName);
            Assert.AreEqual(expectedProduct.ProductDescription, actualProduct.ProductDescription);
            Assert.AreEqual(expectedProduct.CurrentPrice, actualProduct.CurrentPrice);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            // Arrange
            ProductRepository productRepository = new ProductRepository();
            Product updatedProduct = new Product(2);
            updatedProduct.CurrentPrice = 18M;
            updatedProduct.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
            updatedProduct.ProductName = "Sunflowers";
            updatedProduct.HasChanges = true;

            // Act
            bool actualProduct = productRepository.Save(updatedProduct);

            // Assert
            Assert.AreEqual(true, actualProduct);
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            // Arrange
            ProductRepository productRepository = new ProductRepository();
            Product updatedProduct = new Product(2);
            updatedProduct.CurrentPrice = null;
            updatedProduct.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
            updatedProduct.ProductName = "Sunflowers";
            updatedProduct.HasChanges = true;

            // Act
            bool actualProduct = productRepository.Save(updatedProduct);

            // Assert
            Assert.AreEqual(false, actualProduct);
        }
    }
}
