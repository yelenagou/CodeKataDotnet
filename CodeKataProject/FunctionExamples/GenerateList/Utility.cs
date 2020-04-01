using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GenerateList
{
	public class Utility
	{
		public static Stream GeneratePlanetStrem()
		{
			var planets = String.Join(Environment.NewLine, new[] {"Mercury","Venus","Earth",
			"Mars", "Jupiter", "Saturn", "Uranus","Nepturne"});
			var buffer = Encoding.UTF8.GetBytes(planets);
			var stream = new MemoryStream();
			stream.Write(buffer, 0, buffer.Length);
			stream.Position = 0L;

			return stream;
		}
        public static string GenerateOrderedList(IDictionary<int, string> options, string id,
   bool includeSun)
        {
            var html = new StringBuilder();
            html.AppendFormat($"<ol id={id}>");
            html.AppendLine();

            if (includeSun)
            {
                html.AppendLine("\t<li>The Sun/li>");
            }

            foreach (var opt in options)
            {
                html.AppendFormat($"\t<li value={opt.Key}>{opt.Value}</li>");
                html.AppendLine();
            }

            html.AppendLine("</ol>");

            return html.ToString();
        }
    }
}
