using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve one order
        /// </summary>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            // Create an instance of the Customer class
            // Pass in the requested id
            Order order = new Order(orderId);

            // Code that retrieves the defined customer

            // Temporary hard-coded values to return
            // a populated customer
            if (orderId == 10)
            {
                // Use current year in hard-coded data
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 10, 19, 16, 30, 30, new TimeSpan(7, 0, 0));
            }
            return order;
        }

        /// <summary>
        /// Save the current order
        /// </summary>
        /// <returns></returns>
        public bool Save(Order order)
        {
            bool success = true;

            if (order.HasChanges)
            {
                if (order.IsValid)
                {
                    if (order.IsNew)
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
