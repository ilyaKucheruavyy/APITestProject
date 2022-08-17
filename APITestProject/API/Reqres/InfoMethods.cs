using APITestProject.Base;
using RestSharp;

namespace APITestProject.API.Reqres
{
    public class InfoMethods : BaseApiMethods
    {
        public RestResponse GetInfoAboutSingleUser(int userId)
        {
            var request = new RestRequest($"/api/users/{userId}", Method.Get);
            var response = Client.ExecuteAsync(request).Result;

            return response;
        }

        public RestResponse GetListOfTheUsers(int pageNumber)
        {
            var request = new RestRequest($"/api/users?page={pageNumber}", Method.Get);
            var response = Client.ExecuteAsync(request).Result;

            return response;
        }
    }
}
