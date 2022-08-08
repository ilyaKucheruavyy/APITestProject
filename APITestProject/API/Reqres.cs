using APITestProject.Base;
using APITestProject.DTO;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers;


namespace APITestProject.API
{
    public class Reqres: BaseApiMethods
    {
        public RestResponse GetInfoAboutUser(UsersInfoDTO userInfoBody)
        {
            var request = new RestRequest("", Method.Get);
            var requestBody = JsonConvert.SerializeObject(userInfoBody);
            request.AddStringBody(requestBody, ContentType.Json);
            var response = Client.ExecuteAsync(request).Result;

            return response;
        }

        public RestResponse PostCreateNewUSer(UsersInfoDTO userinfoBody)
        {
            var request = new RestRequest("", Method.Post);
            var requestBody = JsonConvert.SerializeObject(userinfoBody);
            request.AddStringBody(requestBody, ContentType.Json);
            var response = Client.ExecuteAsync(request).Result;

            return response;
        }

        public RestResponse PutUpdateInfo(UsersInfoDTO userInfoBody)
        {
            var request = new RestRequest("", Method.Put);
            var requestBody = JsonConvert.SerializeObject(userInfoBody);
            request.AddStringBody(requestBody, ContentType.Json);
            var response = Client.ExecuteAsync(request).Result;

            return response;
        }

        public RestResponse DeleteUser()
        {
            var request = new RestRequest("", Method.Delete);
            var response = Client.ExecuteAsync(request).Result;

            return response;
        }

        public RestResponse PostUserRegistration(UsersInfoDTO userInfoBody)
        {
            var request = new RestRequest("", Method.Post);
            var requestBody = JsonConvert.SerializeObject(userInfoBody);
            request.AddStringBody(requestBody, ContentType.Json);
            var response = Client.ExecuteAsync(request).Result;

            return response;
        }

        public RestResponse PostUserLogin(UsersInfoDTO userInfoBody)
        {
            var request = new RestRequest("", Method.Post);
            var requestBody = JsonConvert.SerializeObject(userInfoBody);
            request.AddStringBody(requestBody, ContentType.Json);
            var response = Client.ExecuteAsync(request).Result;

            return response;
        }
    }
}
