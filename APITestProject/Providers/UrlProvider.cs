using APITestProject.Extensions;
using APITestProject.Utilities;

namespace APITestProject.Providers
{
    public static class UrlProvider
    {
        public static string ReqresUrl => Config.Read.ByKey("ReqresUrl");
    }
}