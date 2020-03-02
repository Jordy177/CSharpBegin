using System;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public string FullName
        {
            get
            {
                if (!string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName))
                    return LastName + ", " + FirstName;
                else if (string.IsNullOrEmpty(FirstName))
                    return LastName;
                else if (string.IsNullOrEmpty(LastName))
                    return FirstName;
                else
                    return "Has no name!";
            }

        }

        public Customer()
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }




        /// <summary>
        /// Checks if what is given is true
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

    }

}
