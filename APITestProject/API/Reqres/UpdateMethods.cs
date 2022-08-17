using APITestProject.Base;
using APITestProject.DTO;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers;

namespace APITestProject.API.Reqres
{
    public class UpdateMethods : BaseApiMethods
    {
        public RestResponse PutUpdateInfo(UsersInfoDTO userInfoBody, int userId)
        {
            var request = new RestRequest($"/api/users/{userId}", Method.Put);
            var requestBody = JsonConvert.SerializeObject(userInfoBody);
            request.AddStringBody(requestBody, ContentType.Json);
            var response = Client.ExecuteAsync(request).Result;

            return response;
        }
    }
}
