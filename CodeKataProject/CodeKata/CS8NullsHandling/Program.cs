
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


        }
    }
}
