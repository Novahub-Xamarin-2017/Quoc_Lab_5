using System;
using exercise1.models;
using RestSharp;
using Retrofit.Net.Attributes.Methods;
using Retrofit.Net.Attributes.Parameters;

namespace exercise1
{
    public interface ICampaignService
    {
        [Post("campaigns")]
        RestResponse<Campaign> CreateCampaigns([Body] Object campaign);

        [Put("campaigns/{campaignId}/content")]
        RestResponse<bool> SetContent([Path("campaignId")] string campaignId, [Body] object content);

        [Post("campaigns/{campaignId}/actions/send")]
        RestResponse<bool> SendCampaign([Path("campaignId")] string campaignId);
    }
}