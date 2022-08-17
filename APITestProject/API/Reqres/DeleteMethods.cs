using APITestProject.Base;
using RestSharp;

namespace APITestProject.API.Reqres
{
    public class DeleteMethods: BaseApiMethods
    {
        public RestResponse DeleteUser(int userId)
        {
            var request = new RestRequest($"/api/users/{userId}", Method.Delete);
            var response = Client.ExecuteAsync(request).Result;

            return response;
        }
    }
}
