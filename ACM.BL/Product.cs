﻿using System;
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

        public Product Retrieve(int productId)
        {
            return new Product();
        }

        public bool Save()
        {
            return true;
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

