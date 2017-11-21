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
            var list = ObjectHelper.GetListObject();
            Console.WriteLine(listService.CreateList(list).ResponseStatus);
            // add an email to list
            var listId = "ea602c2f5c";
            var emailSubcriber = ObjectHelper.GetEmailObject("quoctran2124@gmail.com");
            Console.WriteLine(listService.AddEmail(listId,emailSubcriber));
            // create a new campaign
            var campaignService = GetService<ICampaignService>(url, apiKey);
            var campaign = ObjectHelper.GetCampaignObject(listId);
            Console.WriteLine(campaignService.CreateCampaigns(campaign).ResponseStatus);
            // set content for a campaign
            var campaignId = "39494cd8ea";
            var content = ObjectHelper.GetContentObject("Hello there!");
            Console.WriteLine(campaignService.SetContent(campaignId,content));
            // send campaign
            Console.WriteLine(campaignService.SendCampaign(campaignId));
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
