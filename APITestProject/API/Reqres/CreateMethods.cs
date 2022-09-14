using APITestProject.Base;
using APITestProject.DTO;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers;

namespace APITestProject.API.Reqres
{
    public class CreateMethods: BaseApiMethods
    {
        public RestResponse PostCreateNewUser(UsersInfoDTO userinfoBody)
        {
            var request = new RestRequest("/api/users", Method.Post);
            var requestBody = JsonConvert.SerializeObject(userinfoBody);
            request.AddStringBody(requestBody, ContentType.Json);
            var response = Client.ExecuteAsync(request).Result;

            return response;
        }
    }
}
