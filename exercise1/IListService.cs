using System;
using RestSharp;
using Retrofit.Net.Attributes.Methods;
using Retrofit.Net.Attributes.Parameters;

namespace exercise1
{
    public interface IListService
    {
        [Post("lists")]
        RestResponse<bool> CreateList([Body] Object list);

        [Post("lists/{listId}/members")]
        RestResponse<bool> AddEmail([Path("listId")] string listId, [Body] object email);
    }
}
