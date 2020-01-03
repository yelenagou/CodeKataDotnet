using HandlingNulls.DataModel;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace HandlingNulls
{
    public class NullableOfType
    {
    /// <summary>
    /// Checks to see if a field has value. A field was identified as nullable
    /// </summary>
    /// <param name="customer">Customer object</param>
        public static void Write(Customer? customer)
        {
            if(customer is null)
            {
                Console.WriteLine("No customer specified");
                return;
            }
            Out.WriteLine($"name {customer.Name}");


            if (customer.DateBecameCustomer.HasValue)
            {
                Out.WriteLine($"The date value is {customer.DateBecameCustomer.Value}");
            }
            else
            {
                Out.WriteLine("The client has not date");
            }
        }
        /// <summary>
        /// Specify number of days since last login
        /// GetValueOrDefault example
        /// HasValue with default example using ?
        /// Using null coalescing ??
        /// </summary>
        /// <param name="customer"></param>
        public static void WriteDays(Customer customer)
        {
            //int days = client.DaysSinceLastLogin.GetValueOrDefault(-1);
            //int days = client.DaysSinceLastLogin.HasValue ? client.DaysSinceLastLogin.Value : -1; ;
            int days = customer.NumberOfDays ?? -1;

            Out.WriteLine($"{days} days since became a client");
            if (customer.NumberOfDays == null)
            {
                Out.WriteLine("No date sepcified");
            }
            else
            {
                Out.WriteLine($"Number of days since customer {customer.NumberOfDays}");
            }
        }
    }
}
