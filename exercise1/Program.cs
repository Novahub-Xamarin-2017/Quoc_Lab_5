using System;
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
            var url = $"https://{dataCenter}.api.mailchimp.com/3.0";
            // init service
            var listService = GetService<IListService>(url, apiKey);
            // create a new list
            var list = MailChimpObjects.CreateListObject();
            var listResponse = listService.CreateList(list);
            Console.WriteLine($"Create List : {listResponse.ResponseStatus}");
            // add an email to list
            var listId = listResponse.Data.Id;
            var emailSubcriber = MailChimpObjects.CreateEmailObject("stevelee2497@gmail.com");
            Console.WriteLine($"Add Email : {listService.AddEmail(listId, emailSubcriber).ResponseStatus}");
            // create a new campaign
            var campaignService = GetService<ICampaignService>(url, apiKey);
            var campaign = MailChimpObjects.CreateCampaignObject(listId);
            var campaignResponse = campaignService.CreateCampaigns(campaign);
            Console.WriteLine($"Create campaign : {campaignResponse.ResponseStatus}");
            // set content for a campaign
            var campaignId = campaignResponse.Data.Id;
            var content = MailChimpObjects.CreateContentObject("Hello there!");
            Console.WriteLine($"Set content for campaign : {campaignService.SetContent(campaignId, content).ResponseStatus}");
            // send campaign
            Console.WriteLine($"Send campaign : {campaignService.SendCampaign(campaignId).ErrorException}");
            Console.ReadKey();
        }
        
        private static T GetService<T>(string url, string apiKey) where T : class
        {
            var restClient = new RestClient(url);
            restClient.Authenticator = new HttpBasicAuthenticator("username", apiKey);
            var adapter = new RestAdapter(restClient);
            return adapter.Create<T>();
        }
    }
}
