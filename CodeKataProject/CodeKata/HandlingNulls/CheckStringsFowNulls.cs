using System;
using static System.Console;
namespace HandlingNulls
{
    /// <summary>
    /// Working with ampty strings
    /// </summary>
    public class CheckStringsFowNulls
    {
        public static string ChecIsNullOrEmpty(string inputValue)
        {
            //Reference Type
            string name = inputValue;
            //string name = null;
            //string name = "";

            //a string can also contain spaces. 
            //static convinience methods
            if (string.IsNullOrEmpty(name))
            {
                WriteLine($"The string is null or empty");
            }
            else
            {
                WriteLine($"The string is {name}");
            }
            return name;
        }
        /// <summary>
        /// Check if string contains spaces
        /// </summary>
        /// <param name="inputValue">string</param>
        public static void CheckIsNullOrWhiteSpace(string inputValue)
        {
            //Reference Type
            string name = inputValue;
            //string name = null;
            //string name = "";

            //will not return null if string contains spaces
           
            if (string.IsNullOrWhiteSpace(name))
            {
                WriteLine($"The string is null or empty");
            }
            else
            {
                WriteLine($"The string is {name}");
            }

        }
    }
}
