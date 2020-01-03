
using HandlingNulls;
using HandlingNulls.DataModel;
using System;

namespace CS8NullsHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message
            {
                Text = "Hello There",
                From = null
            };
            //string messageString = null;
            //null coalescing

            MessagePopulator.Populate(message);
            Console.WriteLine($"From: {message.From ?? "No from"} Message: {message.Text} {message.ToUpperFrom()}");
            Console.WriteLine($"{message.From!.Length}");
            Console.WriteLine("Press Enter To End");
                
            Console.ReadLine();

            Customer[]? customers =
            {
                new Customer("Abigail"),
                new Customer("Dom"),
                new Customer(null),
                null
            };
            NullableOfType.Write(customers[0]);
            NullableOfType.Write(customers[1]);
            NullableOfType.Write(customers[2]);
            NullableOfType.Write(customers[3]);




        }
    }
}
