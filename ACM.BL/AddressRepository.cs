using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        /// <summary>
        /// Retrieve one order
        /// </summary>
        /// <returns></returns>
        public Address Retrieve(int addressId)
        {
            // Create an instance of the Customer class
            // Pass in the requested id
            Address address = new Address(addressId);

            // Code that retrieves the defined customer

            // Temporary hard-coded values to return
            // a populated customer
            if (addressId == 1)
            {
                // Use current year in hard-coded data
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";

            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            List<Address> addressList = new List<Address>();
            Address address = new Address(1);
            address.AddressType = 1;
            address.StreetLine1 = "Bag End";
            address.StreetLine2 = "Bagshot row";
            address.City = "Hobbiton";
            address.State = "Shire";
            address.Country = "Middle Earth";
            address.PostalCode = "144";
            addressList.Add(address);

            address = new Address(2);
            address.AddressType = 2;
            address.StreetLine1 = "Green Dragon";
            address.City = "Bywater";
            address.State = "Shire";
            address.Country = "Middle Earth";
            address.PostalCode = "146";
            addressList.Add(address);

            return addressList;
        }

        /// <summary>
        /// Save the current order
        /// </summary>
        /// <returns></returns>
        public bool Save(Address address)
        {
            bool success = true;

            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
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
