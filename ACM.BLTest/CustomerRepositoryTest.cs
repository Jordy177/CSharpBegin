using ACM.BL;
using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace ACM.BLTest
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            //-- Arange
            var customerRepository = new CustomerRepository();
            
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            //-- Act
            var actual = customerRepository.Retrieve(1);

            //-- Assert
            Assert.Equal(expected.CustomerId, actual.CustomerId); 
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
        }
    }
}