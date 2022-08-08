using APITestProject.API;
using APITestProject.Providers;
using RestSharp;

namespace APITestProject.Helpers
{
    public class RestWebClient
    {
        public RestClient Reqres { get; }

        public RestWebClient()
        {
            Reqres = new RestClient(UrlProvider.ReqresUrl);
        }
    }
}
