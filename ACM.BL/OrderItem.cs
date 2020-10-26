using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {
            
        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Validates the orderItem data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            if (ProductId <= 0) return false;
            if (Quantity <= 0) return false;
            if (PurchasePrice <= 0) return false;
            return true;
        }

        /// <summary>
        /// Save the current orderItem
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // TODO
            return true;
        }

        /// <summary>
        /// Retrieve one orderItem
        /// </summary>
        /// <returns></returns>
        public OrderItem Retrieve()
        {
            // TODO
            return new OrderItem();
        }
    }
}
