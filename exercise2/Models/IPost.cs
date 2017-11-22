using System.Collections.Generic;
using RestSharp;
using Retrofit.Net.Attributes.Methods;
using Retrofit.Net.Attributes.Parameters;

namespace exercise2.Models
{
    public interface IPost
    {
        [Get("posts")]
        RestResponse<List<Post>> GetPost();

        [Get("posts/{id}")]
        RestResponse<Post> GetPost([Path("id")] int id);
    }
}