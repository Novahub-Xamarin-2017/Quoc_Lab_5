using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using Newtonsoft.Json;
using Retrofit.Net;

namespace exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> urls = new List<string>()
            {
                "http://danabus.vn/data/2/bus-services.json",
                "http://danabus.vn/data/2/bus-services/5.json",
                "http://danabus.vn/data/2/bus-services/7.json",
                "http://danabus.vn/data/2/bus-services/8.json",
                "http://danabus.vn/data/2/bus-services/11.json",
                "http://danabus.vn/data/2/bus-services/12.json"
            };
            urls.ForEach(ConvertJsonToXml);
            Console.ReadKey();
        }

        private static void ConvertJsonToXml(string url)
        {
            var adapter = new RestAdapter(url);
            var service = adapter.Create<IGetJsonService>();
            var response = service.GetBusServices();
            var doc = JsonConvert.DeserializeXmlNode(response.Content, "root");
            var fileName = GetXmlFileName(url);
            File.WriteAllText(fileName, XDocument.Parse(doc.InnerXml).ToString());
        }

        private static string GetXmlFileName(string url)
            => url.Substring(url.LastIndexOf('/') + 1).Replace("json", "xml");
    }
}
