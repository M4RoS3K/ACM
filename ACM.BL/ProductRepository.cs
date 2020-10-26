using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieve one product
        /// </summary>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // Create an instance of the Customer class
            // Pass in the requested id
            Product product = new Product(productId);

            // Code that retrieves the defined customer

            // Temporary hard-coded values to return
            // a populated customer
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 7 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 19.99M;
            }

            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            return product;
        }

        /// <summary>
        /// Save the current product
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            bool success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Call an insert stored procedure
                    }
                    else
                    {
                        // Call an update stored procedure
                    }
                } 
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}
