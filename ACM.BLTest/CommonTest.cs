using ACM.BL;
using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;
using Acme.Common;

namespace ACM.BLTest
{
    public class CommonTest
    {
        [Fact]
        public void TestStringHandler()
        {
            //Arrange
            string expected = "Screw Driver";

            //Act
            string setup = "ScrewDriver";
            string actual = setup.ReturnCleanString();

            //Result
            Assert.Equal(expected, actual);
        }
    }
}