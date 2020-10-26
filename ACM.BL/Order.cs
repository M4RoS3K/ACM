using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order : EntityBase
    {
        public Order() : this(0)
        {

        }

        public Order(int orderdId)
        {
            OrderId = orderdId;
            OrderItems = new List<OrderItem>();
        }

        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int CustomerId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddresId { get; set; }

        /// <summary>
        /// Validates the order data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            if (OrderDate == null) return false;
            return true;
        }

        public override string ToString() => $"{OrderDate.Value.Date} ({OrderId})";
    }
}
