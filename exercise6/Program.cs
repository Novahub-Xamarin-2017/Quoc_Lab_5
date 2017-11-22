using System.IO;
using System.Xml;
using Newtonsoft.Json;

namespace exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new XmlDocument();
            doc.Load("books.xml");
            string jsonText = JsonConvert.SerializeXmlNode(doc);
            File.WriteAllText("books.json",jsonText);
        }
    }
}
