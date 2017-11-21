using System;
using Newtonsoft.Json;
using RestSharp;
using Retrofit.Net;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataCenter = "us17";
            var apiKey = "ed37a130dbadee9671f725ebdf03583a-us17";
            var listId = "ea602c2f5c";
            var campaignId = "39494cd8ea";
            var url = $"https://{dataCenter}.api.mailchimp.com/3.0";
            // init service
            var service = GetService(url, apiKey);
            // create a new list
            var list = GetListObject();
            Console.WriteLine(service.CreateList(list).ResponseStatus);
            // add an email to list
            var emailSubcriber = GetEmailObject("quoctran2124@gmail.com");
            Console.WriteLine(service.AddEmail(listId,emailSubcriber));
            // create a new campaign
            var campaign = GetCampaignObject(listId);
            Console.WriteLine(service.CreateCampaigns(campaign).ResponseStatus);
            // set content for a campaign
            var content = GetContentObject("Hello there!");
            Console.WriteLine(service.SetContent(campaignId,content));
            // send campaign
            Console.WriteLine(service.SendCampaign(campaignId));
            Console.ReadKey();
        }
        
        private static IHelper GetService(string url, string apiKey)
        {
            var restClient = new RestClient(url);
            restClient.Authenticator = new HttpBasicAuthenticator("username", apiKey);
            var adapter = new RestAdapter(restClient);
            return adapter.Create<IHelper>();
        }

        private static Object GetListObject()
            => new
            {
                name = "Xamarin test 2",
                contact = new
                {
                    company = "Novahub",
                    address1 = "155",
                    address2 = "Nguyen Van Linh",
                    city = "Danang",
                    state = "GA",
                    zip = "550000",
                    country = "VN",
                    phone = ""
                },
                permission_reminder = "Test reminder",
                campaign_defaults = new
                {
                    from_name = "Tran Ngoc Quoc",
                    from_email = "quoctran2124@gmail.com",
                    subject = "MailChimp Demo",
                    language = "en",
                },
                email_type_option = true
            };

        private static object GetCampaignObject(string listId)
            => new
            {
                recipients = new
                {
                    list_id = listId
                },
                type = "regular",
                settings = new
                {
                    subject_line = "Test send email",
                    reply_to = "stevelee2421@outlook.com",
                    from_name = "Quoc Tran"
                }
            };

        private static object GetEmailObject(string email)
            => new
            {
                email_address = email,
                merge_fields =
                new
                {
                    FNAME = "Foo",
                    LNAME = "Bar"
                },
                status_if_new = "subscribed"
            };

        private static object GetContentObject(string content)
            => new
            {
                html = content,
            };
    }
}
