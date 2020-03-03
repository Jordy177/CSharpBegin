using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class Product
    {

        public int ProductId { get; private set; }
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }

        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}


