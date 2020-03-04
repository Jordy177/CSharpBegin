using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Address
    {
        public int AddressId {get; private set; }
        public int AddressType { get; set; }
        public string StreetLine1 { get; set; }
        public string Streetline2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
  

        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }

        public bool Validate()
        {
            var isValid = true;

            if (PostalCode == null) isValid = false;

            return isValid;
        }


    }
}