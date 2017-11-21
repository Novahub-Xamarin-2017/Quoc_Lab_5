using System;
using System.IO;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var jsonFile = File.ReadAllText("books.json");
                var doc = JsonConvert.DeserializeXmlNode("{\"Books\":" + jsonFile + "}", "root");
                File.WriteAllText("books.xml", XDocument.Parse(doc.InnerXml).ToString());
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
