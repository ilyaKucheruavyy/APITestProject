using APITestProject.Base;
using RestSharp;

namespace APITestProject.Extensions
{
    public static class RestClientExtensions
        {
            public static T InitApiMethods<T>(this RestClient client) where T : IBaseApiMethods, new()
            {
                var requestMethods = new T { Client = client };
                return requestMethods;
            }
        }
    }
