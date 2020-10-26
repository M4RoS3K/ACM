using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Address : EntityBase
    {
        public Address()
        {

        }

        public Address(int addresId)
        {
            AddressId = addresId;
        }

        public int AddressId { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public int AddressType { get; set; }

        public override bool Validate()
        {
            if (string.IsNullOrWhiteSpace(PostalCode)) return false;
            return true;
        }
    }
}