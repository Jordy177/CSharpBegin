using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository {get; set; }
        public CustomerRepository()
        {
            var addressRepository = new AddressRepository();
        }
        
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Bilbo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerID(customerId).ToList();
            }

            return customer;
        }

        public bool Save()
        {
            return true;
        }
    }
}