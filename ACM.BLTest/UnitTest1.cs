using ACM.BL;
using System;
using Xunit;

namespace ACM.BLTest
{
    public class UnitTest1
    {
        [Fact]
        public void FullNameTestValid()
        {
            //-- Arange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameFirstNameEmpty()
        {
            //-- Arange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameLastNameEmpty()
        {
            //-- Arange
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            string expected = "Bilbo";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.Equal(expected, actual);
        }
       
        [Fact]
        public void ValidMisslingLastName()
        {
            //-- Arange
            Customer customer = new Customer
            {
                EmailAddress = "fbaggins@hobbiton.me"
            };
            var expected = false;

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.Equal(expected, actual);
        }
    }
}
