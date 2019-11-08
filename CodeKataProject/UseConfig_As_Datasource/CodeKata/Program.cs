using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace CodeKata
{
    class Program
    {
        /// <summary>
        /// Initialize configuration builder for a console application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
          var builder = new ConfigurationBuilder()
         .SetBasePath(Directory.GetCurrentDirectory())
         .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            Console.WriteLine(configuration.GetConnectionString("Storage"));
        }
    }
}
