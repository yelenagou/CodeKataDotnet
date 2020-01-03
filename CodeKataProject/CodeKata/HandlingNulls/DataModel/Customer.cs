using System;
using System.Collections.Generic;
using System.Text;

namespace HandlingNulls.DataModel
{
    public class Customer
    {
        public string Name { get; set; }
        public int? NumberOfDays { get; set; }
        public DateTime? DateBecameCustomer { get; set; }
        public Customer(string name)
        {
            Name = name;
        }
    }
}
