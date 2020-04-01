using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodeKata
{
    /// <summary>
    /// New version of the language library disposes of using when scope of the function ends
    /// </summary>
    public class NewUsingStatement
    {
        /// <summary>   
        /// Read File and print contnets
        /// </summary>
        /// <param name="filePath"></param>
        public void ReadFile(string filePath)
        {
            using FileStream fs = File.OpenRead(filePath);
            byte[] b = new byte[fs.Length];
            UTF8Encoding temp = new UTF8Encoding(true);
            while (fs.Read(b, 0, b.Length) > 0)
            {
                Console.WriteLine(temp.GetString(b));
            }
        }
    }
}
