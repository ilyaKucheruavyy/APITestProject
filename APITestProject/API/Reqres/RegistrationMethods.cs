using APITestProject.Base;
using APITestProject.DTO;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers;

namespace APITestProject.API.Reqres
{
    public  class RegistrationMethods : BaseApiMethods
    {
        public RestResponse PostUserRegistration(UsersInfoDTO userInfoBody)
        {
            var request = new RestRequest("/api/register", Method.Post);
            var requestBody = JsonConvert.SerializeObject(userInfoBody);
            request.AddStringBody(requestBody, ContentType.Json);
            var response = Client.ExecuteAsync(request).Result;

            return response;
        }

        public RestResponse PostUserLogin(UsersInfoDTO userInfoBody)
        {
            var request = new RestRequest("/api/login", Method.Post);
            var requestBody = JsonConvert.SerializeObject(userInfoBody);
            request.AddStringBody(requestBody, ContentType.Json);
            var response = Client.ExecuteAsync(request).Result;

            return response;
        }
    }
}
