using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Accounting
{
    internal class Customer
    {
        public string customerId;
        private string customerName;

        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }

        public string CustomerId
        {
            get
            {
                return customerId;
            }
            set
            {
                customerId = value;
            }
        }
    }
}
