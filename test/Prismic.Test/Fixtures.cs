using System;
using System.IO;
using Newtonsoft.Json.Linq;
using prismic;

namespace Prismic.Test
{
    public class Fixtures
    {
        public static JToken Get(String file)
        {
            var directory = Directory.GetCurrentDirectory();
            var path = string.Format("{0}{1}fixtures{1}{2}", directory, Path.DirectorySeparatorChar, file);
            string text = File.ReadAllText(path);
            return JToken.Parse(text);
        }

        public static Document GetDocument(String file)
        {
            var json = Get(file);
            return Document.Parse(json);
        }
    }        
}
