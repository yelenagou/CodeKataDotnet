using System;
using System.Collections.Generic;
using System.Text;

namespace HandlingNulls.DataModel
{
    public class Message
    {
        public string From { get; set; }
        public string Text { get; set; } = "";

        //public string ToUpperFrom()
        //{
        //    if(From is null)
        //    {
        //        return "";
        //    }
        //    return From.ToUpperInvariant();

        //}
        public string ToUpperFrom() => From?.ToUpperInvariant();
            
    }
}
